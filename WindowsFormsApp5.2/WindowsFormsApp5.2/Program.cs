using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5._2
{
	public class düzey<T>
	{
		public nod<T> data;
		public int level;
		public düzey(nod<T> veri, int say)
		{
			data = veri;
			level = say;
		}
	}
	public class nod<T>
	{
		public nod<T> parent;
		public nod<T> left;
		public nod<T> right;
		public T data;
		public nod(T ek)
		{
			this.data = ek;
		}
	}
	public class bintree<T> where T : IComparable<T>// Karşılaştırılabilir değişken alan ağaç
													//Bu ağaçta yalnızca karşılaştırılabilir değişken kullanıldığı için atanan generic tipin comparable olması gerekmektedir
	{

		private List<T> balanced;//Dengeleme için kullanılan liste
		public nod<T> root;

		public bintree()
		{
			root = null;
		}
		public void Add(T yeni)//Kullanılabilir add metodu
		{
			nod<T> tt = new nod<T>(yeni);
			this.add(tt);
		}
		private void inorder(nod<T> node, List<düzey<T>> list)
		{
			if (node != null)
			{
				inorder(node.left, list);
				list.Add(new düzey<T>(node, seviye_dondur(node)));
				inorder(node.right, list);
			}
		}
		public List<düzey<T>> in_order()
		{
			List<düzey<T>> listele = new List<düzey<T>>();
			inorder(root, listele);
			return listele;
		}
		private void preorder(nod<T> node, List<düzey<T>> list)
		{
			if (node != null)
			{
				list.Add(new düzey<T>(node, seviye_dondur(node)));
				inorder(node.left, list);
				inorder(node.right, list);
			}
		}
		public List<düzey<T>> pre_order()
		{
			List<düzey<T>> listele = new List<düzey<T>>();
			preorder(root, listele);
			return listele;
		}
		private void postorder(nod<T> node, List<düzey<T>> list)
		{
			if (node != null)
			{
				inorder(node.left, list);
				inorder(node.right, list);
				list.Add(new düzey<T>(node, seviye_dondur(node)));
			}
		}
		public List<düzey<T>> post_order()
		{
			List<düzey<T>> listele = new List<düzey<T>>();

			postorder(root, listele);
			return listele;
		}
		public int seviye_dondur(nod<T> goal)
		{
			return level(goal, root, 0);
		}
		private int level(nod<T> goal, nod<T> say, int stage)
		{
			if (say == null)
			{
				return -1;
			}
			if (say.Equals(goal))
			{
				return stage;
			}
			else if (level(goal, say.left, stage + 1) < level(goal, say.right, stage + 1))
			{
				return level(goal, say.right, stage + 1);
			}
			else
			{
				return level(goal, say.left, stage + 1);
			}
		}
		private void add(nod<T> yeni)//add metodu -PRİVATE'TİR KULLANILMAZ
		{
			nod<T> c = root;
			if (root == null)
			{
				root = yeni;
			}
			else
			{
				while (c != null)
				{
					if (c.data.CompareTo(yeni.data) == -1)
					{
						if (c.right == null)
						{
							c.right = yeni;
							yeni.parent = c;
							c = null;
						}
						else
						{
							c = c.right;
						}
					}
					else
					{
						if (c.left == null)
						{
							c.left = yeni;
							yeni.parent = c;
							c = null;
						}
						else
						{
							c = c.left;
						}
					}
				}

			}
		}
		public bool isEmpty()//Ağacın boş olup olmadığını kontrol eder.
		{
			return root == null;
		}
		private void balance_adder(List<T> a)
		{//Verilen listeyi ağaca dengeli olacak şekilde ekleyen metod -RECURSİVE -PRİVATE'TİR KULLANILMAZ
			if (a.Count == 1)
			{
				this.Add(a[0]);
			}
			else if (a.Count != 0)
			{
				if (a.Count % 2 == 0)
				{
					int pivot = a.Count / 2;
					this.Add(a[pivot]);
					balance_adder(a.GetRange(0, pivot));

					balance_adder(a.GetRange(pivot + 1, pivot - 1));
				}
				else
				{
					int pivot = a.Count / 2;
					this.Add(a[pivot]);
					balance_adder(a.GetRange(0, pivot));

					balance_adder(a.GetRange(pivot + 1, pivot));
				}
			}
		}
		public void balance()//Ağacın dengeleme metodu
		{
			balanced = new List<T>();
			while (isEmpty() == false)
			{
				T temp = this.remove(root);
				balanced.Add(temp);
			}
			balanced.Sort();
			balance_adder(balanced);
		}
		private nod<T> ata(nod<T> a, nod<T> b)//Search metodunun yardımcı metodu
		{
			if (a == null && b != null)
			{
				return b;
			}
			else if (a != null && b == null)
			{
				return a;
			}
			else if (a != null && b != null)
			{
				return a;
			}
			else
			{
				return null;
			}
		}
		private nod<T> search(T ara, nod<T> bak)//arama metodu -RECURSİVE -PRİVATE'TİR KULLANILMAZ
		{
			if (bak == null)
			{
				return null;
			}
			else if (ara.Equals(bak.data))
			{
				return bak;
			}
			else
			{
				return ata(search(ara, bak.left), search(ara, bak.right));
			}
		}
		public void Uygula(nod<turistik> rr, List<otel> a)
		{
			if (rr == null)
			{

			}
			else
			{
				foreach (otel i in rr.data.oteller)
				{
					a.Add(i);
				}
				Uygula(rr.left, a);
				Uygula(rr.right, a);
			}
		}
		public nod<T> search(T ara)//Kullanılabilir arama metodu
		{
			return search(ara, root);
		}
		public void Remove(T sil)//Kullanılabilir silme metodu
		{
			remove(search(sil));
		}
		private T remove(nod<T> e)//Ağaçtan eleman silmek için kullanılan metod -PRİVATE'TİR KULLANILMAZ
		{
			if (e == root)
			{
				nod<T> temp = root;
				if (root.right == null && root.left == null)
				{
					root = null;
					return temp.data;
				}
				else if (root.right == null && root.left != null)
				{
					root = root.left;
					return temp.data;
				}
				else if (e.right != null && e.left == null)
				{
					root = root.right;
					return temp.data;
				}
				else
				{
					nod<T> g = root.left;
					while (g.right != null)
					{
						g = g.right;

					}
					T temper = root.data;
					e.data = g.data;
					g.data = temper;
					return remove(g);
				}

			}
			else if (e.right == null && e.left == null)
			{
				if (e.parent.right == e)
				{
					nod<T> temp = e.parent.right;
					e.parent.right = null;
					return temp.data;
				}
				else
				{
					nod<T> temp = e.parent.left;
					e.parent.left = null;
					return temp.data;
				}
			}
			else if (e.right == null && e.left != null)
			{
				if (e.parent.right == e)
				{
					nod<T> temp = e.parent.right;
					e.parent.right = e.left;
					return temp.data;
				}
				else
				{
					nod<T> temp = e.parent.left;
					e.parent.left = e.left;
					return temp.data;
				}
			}
			else if (e.right != null && e.left == null)
			{
				if (e.parent.right == e)
				{
					nod<T> temp = e.parent.right;
					e.parent.right = e.right;
					return temp.data;
				}
				else
				{
					nod<T> temp = e.parent.left;
					e.parent.left = e.right;
					return temp.data;
				}
			}
			else
			{
				nod<T> g = e.right;
				while (g.left != null)
				{
					g = g.left;
				}
				T temp = e.data;
				e.data = g.data;
				g.data = temp;
				return remove(g);

			}
		}
	}
	public abstract class AbstractHeap
    {
       
        private int Capacity { get; set; }
        internal int Size { get; set; }
        internal oda[] Nodes { get; set; }
       
        public AbstractHeap()
        {
            Capacity = 300;
            Size = 0;
            Nodes = new oda[Capacity];
        }
       
        public void EnlargeIfNeeded()//hata verirse capasity değişkenini 300 yapın.
        {
            if (Size == Capacity)
            {
                Capacity = 2 * Capacity;
                oda[] Nodes_temp = new oda[Capacity];
                for(int i = 0; i < Size; i++)
                {
                    Nodes_temp[i] = this.Nodes[i];
                }
                this.Nodes = new oda[Capacity];
                for (int i = 0; i < Size; i++)
                {
                     this.Nodes[i]= Nodes_temp[i];
                }


               
            }
        }

        public int getLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        public bool hasLeftChild(int parentIndex)
        {
            return getLeftChildIndex(parentIndex) < Size;
        }

        public oda leftChild(int index)
        {
            return Nodes[getLeftChildIndex(index)];
        }

        public int getRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        public bool hasRightChild(int parentIndex)
        {
            return getRightChildIndex(parentIndex) < Size;
        }

        public oda rightChild(int index)
        {
            return Nodes[getRightChildIndex(index)];
        }

        public int getParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        public bool hasParent(int childIndex)
        {
            return getParentIndex(childIndex) >= 0;
        }

        public oda parent(int index)
        {
            return Nodes[getParentIndex(index)];
        }

        public void swap(int index1, int index2)
        {
            oda temp = Nodes[index1];
            Nodes[index1] = Nodes[index2];
            Nodes[index2] = temp;
        }

        
        public oda peek()
        {
            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");

            return Nodes[0];
        }

        /// <summary>
        /// Removes the minimum element at the root of the tree
        /// </summary>
        /// <returns>Int value of minimum element</returns>
        /// <exception cref="">InvalidOperationException when heap is empty</exception>
        public oda pop()
        {
            if (Size == 0) 
                throw new InvalidOperationException("Heap is empty");

            oda item = Nodes[0];
            Nodes[0] = Nodes[Size - 1];
            Size--;
            heapifyDown();
            return item;
        }

        /// <summary>
        /// Add a new item to heap, enlarging the array if needed
        /// </summary>
        /// <returns>void</returns>
        public void add(oda item)
        {
            EnlargeIfNeeded();
            Nodes[Size] = item;
            Size++;
            heapifyUp();
        }
       

       
        internal abstract void heapifyUp();
        internal abstract void heapifyDown();
        
    }
    public class MinHeap : AbstractHeap
    {
        
        public MinHeap() : base()
        {
        }
        
        internal override void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && rightChild(index).fiyat < leftChild(index).fiyat)
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if (Nodes[smallerChildIndex].fiyat < Nodes[index].fiyat)
                    swap(index, smallerChildIndex);
                else
                    break;
                index = smallerChildIndex;
            }
        }
        internal override void heapifyUp()
        {
            int index = Size - 1;

            while (hasParent(index) && parent(index).fiyat > Nodes[index].fiyat)
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }
       
    }
    public class Lineer_Hash
    {
        string[] alfabe ={"a","b","c","ç","d","e","f","g","ğ","h","ı","i","j","k","l","m",
                        "n","o","ö","p","q","r","s","ş","t","u","ü","v","y","z","w","x"};
        public sehir[] table;
        public int size;
        public Lineer_Hash(int len)
        {
            table = new sehir[len];
            size = len;
        }
        private int hash_func(string a)
        {
            string b = a.ToLower();
            string c = "" + b[0];
            int i = 0;
            while (c != alfabe[i])
            {
                i += 1;
            }
            int sıra = (int)((size / alfabe.Length) * i);
            return sıra;
        }
        public void add(sehir k)
        {
            int index = hash_func(k.isim);
            if (table[index] == null)
            {
                table[index] = k;
            }
            else
            {
                while (table[index] != null)
                {
                    index += 1;
                }
                table[index] = k;
            }
        }
        public void Remove(sehir s)
        {
            remove(s.isim);
        }
        private string remove(string k)
        {
            int index = hash_func(k);
            if (table[index].isim.Equals(k))
            {
                table[index] = null;
                return k;
            }
            else
            {
                string a = null;
                for (int i = index; i < table.Length; i++)
                {
                    if (table[i].Equals(k))
                    {
                        table[i] = null;
                        a = k;
                    }
                }
                return a;
            }
        }
        public bool exist(sehir k)
        {
            int index = hash_func(k.isim);
            bool exist = false;
            for (int i = index; i < table.Length; i++)
            {
                if (table[i].Equals(k))
                {
                    exist = true;
                }
            }
            return exist;
        }
    }
    public class Chain_Hash
    {
        string[] alfabe ={"a","b","c","ç","d","e","f","g","ğ","h","ı","i","j","k","l","m",
                        "n","o","ö","p","q","r","s","ş","t","u","ü","v","y","z","w","x"};
        public List<ozellik>[] table;
        int size;
        public Chain_Hash(int len)
        {
            table = new List<ozellik>[len];
            for (int i = 0; i < len; i++)
            {
                table[i] = new List<ozellik>();
            }

            size = len;
        }
        private int hash_func(string o)
        {
            string b = o.ToLower();
            string c = "" + b[0];
            int i = 0;
            while (c != alfabe[i])
            {
                i += 1;
            }
            return i;
        }
        public void Add(ozellik o)
        {
            int index = hash_func(o.attributes);
            table[index].Add(o);
        }
        public void Remove(ozellik o)
        {
            int index = hash_func(o.attributes);
            table[index].Remove(o); ;
        }
        public ozellik Search(string s)
        {
            int index = hash_func(s);
            ozellik goal = null;
            foreach (ozellik oz in table[index])
            {
                if (oz.attributes.Equals(s))
                {
                    goal = oz;
                    break;
                }
            }
            return goal;
        }
    }
    public class sehir
    {
        public string isim;
        public bintree<turistik> yer_agaci;
        public sehir(string ad)
        {
            isim = ad;
            yer_agaci = new bintree<turistik>();
        }
    }
    public class oda
    {
        public string id;
        public otel sahip;
        public int yatak_say;
        public int kapasite;
        public int doluluk;
        public int fiyat;
        public bool dolumu = false;
        public string oda_tipi;
        public List<string> ozellik;
        public List<Üye> musteriler;
        public oda(string num, string ad, int yatak, int kap, int ucret)
        {
            id = num;
            yatak_say = yatak;
            oda_tipi = ad;
            kapasite = kap;
            doluluk = 0;
            fiyat = ucret;
            ozellik = new List<string>();
            musteriler = new List<Üye>();
        }
		public oda(string ad, int yatak, int kap, int ucret)
		{
			yatak_say = yatak;
			oda_tipi = ad;
			kapasite = kap;
			doluluk = 0;
			fiyat = ucret;
			ozellik = new List<string>();
			musteriler = new List<Üye>();
		}
		public void otele_ekle(otel t)
        {
            sahip = t;
        }

    }
    public class kullanıcı
    {
        public string uye_tip;
        private string nickname;
        private string password;
        public string Password { get => password; set => password = value; }
        public string Kullanıcı_adı { get => nickname; set => nickname = value; }

        public kullanıcı(string tip, string name, string pass)
        {
            uye_tip = tip;
            password = pass;
            Kullanıcı_adı = name;
        }
    }
    public class Üye : kullanıcı
    {
        public string isim;
        public int yas;
        public int maas;
        public string meslek;
        public string evli;
        public string cinsiyet;
        public List<oda> rezervasyonlar;
		public List<string> gorusler;
		public Üye(string tip, string nickname, string name, string pass) : base(tip, nickname, pass)
        {
            rezervasyonlar = new List<oda>();
			gorusler = new List<string>();
            isim = name;
        }


		public List<otel> tavsiye(){
			List<Üye> denekler = new List<Üye>();
			foreach(kullanıcı i in test.tum_kullan)
			{
				if(i.uye_tip.Equals("uye")){
					Üye kull = (Üye)i;
					denekler.Add(kull);
				}
			}
			apriori advice = new apriori(denekler,this);
			return advice.calıstır(this);
		}
    }

    public class admin : kullanıcı
    {
        public static int kar;
        string isim;
        public admin(string tip, string ad, string name, string pass) : base(tip, ad, pass)
        {
            isim = ad;
        }
        public void yer_ekle(sehir s, turistik t)
        {
            s.yer_agaci.Add(t);
        }
        public void otel_ekle(turistik t, string isim, string vil)
        {
            t.Add(new otel(isim, vil));
        }
        public void otel_ekle(turistik t, string isim)
        {
            t.Add(new otel(isim));
        }
        public otel otel_arama(string isim, Lineer_Hash f)
        {
            turistik t = null;
            foreach (sehir city in f.table)
            {
                turistik turi = tur_dondur(city.yer_agaci.root, isim);
                if (turi != null)
                {
                    t = turi;
                    break;
                }
            }
            otel otelet = t.otel_arama(isim);
            return otelet;
        }
        private turistik dondur(turistik a, turistik b)
        {
            if (a == null && b == null)
            {
                return null;
            }
            else if (a == null && b != null)
            {
                return b;
            }
            else if (a != null && b == null)
            {
                return a;
            }
            else
            {
                return a;
            }
        }
        private turistik tur_dondur(nod<turistik> a, string b)
        {
            if (a == null)
            {
                return null;
            }
            else if (a.data.otel_bool(b) == true)
            {
                return a.data;
            }
            else
            {
                return dondur(tur_dondur(a.left, b), tur_dondur(a.right, b));
            }
        }


    }
    public class ozellik
    {
        public string attributes;
        public List<otel> otels;
		public ozellik(string isim)
		{
			attributes = isim;
			otels = new List<otel>();
		}
        public override string ToString()
        {
            return attributes;
        }
    }
    public class otel
    {
        public string isim;
        public string ilce;
        public string yer_isim;
        public List<string> bilgiler;

        public List<oda> odalar;


        public otel(string ad, string vil)
        {
            odalar = new List<oda>();

            bilgiler = new List<string>();
            isim = ad;
            ilce = vil;
        }
        public otel(string ad)
        {
            bilgiler = new List<string>();
            odalar = new List<oda>();

            isim = ad;
        }
        public bool rezervasyon(string id, Üye k)//
        {
           
            oda aranan = oda_ara2(id,this.odalar);
            if (aranan == null || aranan.dolumu == true)
            {

                return false;
            }
            else
            {
                int pay = aranan.fiyat / 10;
                admin.kar += pay;
                k.rezervasyonlar.Add(aranan);
                aranan.musteriler.Add(k);
                ////////
                //doyaya yaz. apriori için 
                string dosya_yolu = @"C:\Users\Kenan\Desktop\data\apriorisource.dat";

                StreamWriter sw = File.AppendText(dosya_yolu);
				string temppp = k.Kullanıcı_adı + "," + aranan.id;
                sw.WriteLine(temppp);
                sw.Close();
              
                //////////
                aranan.doluluk += 1;
                if (aranan.doluluk == aranan.kapasite)
                {
                    aranan.dolumu = true;
                }
                return true;
            }
        }
        public void oda_ekle(oda o)
        {
            o.dolumu = false;
            odalar.Add(o);
            odalar.Add(o);
            o.otele_ekle(this);
			string[] odaekle = test.okuma(test.oda_dat);
			List<string> temp = odaekle.ToList();
			int sonnum=Convert.ToInt32(temp.Last().Split('-')[0]) + 1 ;
			string ekstr = sonnum + "-" + o.oda_tipi + "-" + o.yatak_say + "." + o.kapasite + "." + o.fiyat;
			temp.Add(ekstr);
			test.yazma(test.oda_dat, temp.ToArray());
			o.id = sonnum.ToString();
			this.odalar.Add(o);
			string[] a12 = test.okuma(test.otel_dat);
			List<string> a13 = a12.ToList();
			int ig = 0;
			while (ig < a13.Count)
			{
				string[] ayırma = a13[ig].Split('!');
				if (ayırma[0].Equals(o.sahip.isim))
				{
					string[] odanum = ayırma[3].Split(',');
					List<string> tempel = odanum.ToList();
					tempel.Add(sonnum.ToString());
					string topla = String.Join(",", tempel);
					string topla1 = ayırma[0] + "!" + ayırma[1] + "!" + ayırma[2] + "!" + topla;
					a13[ig] = topla1;
				}
				ig++;
			}
			a12 = a13.ToArray();
			test.yazma(test.otel_dat, a12);
		}
        public void oda_sil(oda d)
        {
			oda aranan = d;
            if (aranan != null)
            {
                foreach (Üye uy in aranan.musteriler)
                {
                    uy.rezervasyonlar.Remove(aranan);
					string[] oku = test.okuma(test.apriorisource_dat);
					List<string> eklesil = oku.ToList();
					int t = 0;
					while(t<eklesil.Count){
						if(eklesil[t].Split(',')[1]==aranan.id){
							eklesil.Remove(eklesil[t]);
						}
						t++;
					}
					test.yazma(test.apriorisource_dat, eklesil.ToArray());
                }
                odalar.Remove(aranan);
				string[] odasil = test.okuma(test.oda_dat);
				List<string> temp = odasil.ToList();
				int v = 0;
				while(v<temp.Count){
					if(temp[v].Split('-')[0].Equals(aranan.id)){
						temp.Remove(temp[v]);
					}
					v++;
				}
				test.yazma(test.oda_dat, temp.ToArray());
				string[] a12 = test.okuma(test.otel_dat);
				List<string> a13 = a12.ToList();
				int ig = 0;
				while(ig<a13.Count){
					string[] ayırma = a13[ig].Split('!');
					if (ayırma[0].Equals(aranan.sahip.isim)){
						string[] odanum=ayırma[3].Split(',');
						List<string> tempel = odanum.ToList();
						int u = 0;
						while(u<tempel.Count){
							if(tempel[u].Equals(aranan.id)){
								tempel.Remove(tempel[u]);
							}
							u++;
						}
						string topla = String.Join(",",tempel);
						string topla1 = ayırma[0] + "!" + ayırma[1] + "!" + ayırma[2] + "!" + topla;
						a13[ig] = topla1;
					}
					ig++;
				}
				a12 = a13.ToArray();
				test.yazma(test.otel_dat,a12);
            }
        }
        public oda oda_ara(string isim, List<oda> liste)
        {
            oda hedef = null;
            foreach (oda i in liste)
            {
                if (isim.Equals(i.oda_tipi))
                {
                    hedef = i;
                }
            }
            return hedef;
        }
        public oda oda_ara2(string id, List<oda> liste)
        {
            oda hedef = null;
            foreach (oda i in liste)
            {
                if (id.Equals(i.id) )
                {
                    hedef = i;
                    break;
                }
            }
            return hedef;
        }
        public string toString()
        {
            return isim + " , " + ilce;
        }
    }
    public class turistik : IComparable<turistik>
    {
        public string isim;
        public List<otel> oteller;
        public turistik(string ad)
        {
            isim = ad;
            oteller = new List<otel>();
        }
        public void Add(otel ek)
        {
            oteller.Add(ek);
        }
        public otel otel_arama(string a)
        {
            otel hedef = null;
            foreach (otel ot in oteller)
            {
                if (ot.isim.Equals(a))
                {
                    hedef = ot;
                    break;
                }
            }
            return hedef;
        }
        public bool otel_bool(string a)
        {
            return otel_arama(a) != null;
        }
        public string toString()
        {
            return isim;
        }
        public int CompareTo(turistik other)
        {
            return this.isim.CompareTo(other.isim);
        }
    }
    public class frekans :IComparable
    {
        public otel t;
        public double frek;
        public frekans(otel olet)
        {
            t = olet;
            frek = 0;
        }

		public int CompareTo(object obj)
		{
			frekans f1 = (frekans)obj;
			return this.frek.CompareTo(f1.frek);
		}
	}
    public class kombinasyon : IComparable
    {
        public List<otel> komb;
        public double f;
        public kombinasyon(List<otel> komb1)
        {
            komb = komb1;
        }

        public int CompareTo(object obj)
        {
            kombinasyon a = (kombinasyon)obj;
            if (this.f > a.f)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class apriori
    {
		public List<List<otel>> sınıf = new List<List<otel>>();
        List<Üye> kullanıcılar;
        List<frekans> freks = new List<frekans>();
        List<List<otel>> uzay;
        public apriori(List<Üye> users,Üye uy)
        {
			for(int i=0;i<users.Count;i++){
				List<otel> kullanıcı_otelleri = new List<otel>();
				foreach(oda otti in users[i].rezervasyonlar){
					if(kullanıcı_otelleri.Contains(otti.sahip)==false){
						kullanıcı_otelleri.Add(otti.sahip);
					}
				}
				sınıf.Add(kullanıcı_otelleri);			
			}
            kullanıcılar = users;
            uzay = new List<List<otel>>();
        }
		static IEnumerable<IEnumerable<T>>GetCombinations<T>(IEnumerable<T> list, int length)
		{
			if (length == 1) return list.Select(t => new T[] { t });

			return GetCombinations(list, length - 1)
				.SelectMany(t => list, (t1, t2) => t1.Concat(new T[] { t2 }));
		}
		public List<otel> calıstır(Üye tav)
        {
            list_olustur(tav);
			List<otel> fre = new List<otel>();
			foreach (frekans f in freks)
			{
				fre.Add(f.t);
			}
			IEnumerable<IEnumerable<otel>> t =GetCombinations<otel>(fre,4);
			List<List<otel>> yeni = new List<List<otel>>();
			foreach (IEnumerable<otel> otte in t){
				List<otel> potel = new List<otel>();
				foreach(otel itt in otte){
					potel.Add(itt);
				}
				if(aynı(potel)==false){
					yeni.Add(potel);
				}
			}
            List<otel> tavsiye = frekle(yeni,tav);
            return tavsiye;
        }
		bool ekle(List<List<otel>> ottek, List<otel> denek)
		{
			bool equa = false;
			 foreach(List<otel> ifil in ottek){
				if(equal(ifil,denek)==true){
					equa = true;
					break;
				}
			}
			return !equa;
		}
		bool equal(List<otel> a1, List<otel> b2)
		{
			bool eq = true;
			foreach(otel k in a1){
				if(b2.Contains(k)==false){
					eq = false;
					break;
				}
			}
			return eq;
		}
		bool aynı(List<otel> b2)
		{
			bool aynımı = false;
			int l = 0;
			while(l<b2.Count){
				otel bb = b2[l];
				b2.Remove(bb);
				if(b2.Contains(bb)){
					aynımı = true;
					break;
				}else{
					b2.Add(bb);
				}
				l++;
			}
			return aynımı;
		}
        public List<otel> frekle(List<List<otel>> tumot,Üye t)
        {
			List<kombinasyon> cc = new List<kombinasyon>();
			foreach(List<otel> it in tumot){
				if (aynı(it) == false){
					cc.Add(new kombinasyon(it));
				}
			}
            foreach (kombinasyon aa in cc)
            {
                foreach (List<otel> tt in sınıf)
                {
                    if (var_mı(aa.komb, tt) == true)
                    {
                        aa.f += 1;
                    }
                }
            }
            cc.Sort();
			cc.Reverse();
			List<otel> sonlist=cc.First().komb;
				if(t.rezervasyonlar.Count!=0){ 
				List<frekans> frequence = new List<frekans>();
				foreach (oda g in t.rezervasyonlar)
				{
					exist_otel(g.sahip,frequence);
				}
				frequence.Sort();
				if (frequence.Count==1){
					frekans goal1 = frequence.Last();
					int z = 0;
					while (z < cc.Count)
					{
						if (esitmi(cc[z].komb, goal1.t))
						{
							sonlist = cc[z].komb;
							break;
						}
						z++;
					}
				}else if (frequence.Count != 1)
				{
					frekans goal1 = frequence.Last();
					frekans goal2 = frequence[frequence.Count-2];
					int z = 0;
					while (z < cc.Count)
					{
						if (esitmi(cc[z].komb, goal1.t) && esitmi(cc[z].komb, goal2.t))
						{
							sonlist = cc[z].komb;
							break;
						}
						z++;
					}
				}
			}
            return sonlist;
        }
		private bool esitmi(List<otel> litt,otel i1){
			bool b = false;
			foreach(otel g in litt){
				if(g.isim.Equals(i1.isim)){
					b = true;
					break;
				}
			}
			return b;
		}
        public bool var_mı(List<otel> vd, List<otel> sh)
        {
			bool varmidur = true;
            foreach(otel oteldur in sh){
				if(vd.Contains(oteldur)==false){
					varmidur = false;
					break;
				}
			}
			return varmidur;
        }
        public void list_olustur(Üye uy)
        {
            foreach (List<otel> tt in sınıf)
            {
                foreach (otel i in tt)
                {
                    exist_otel(i,freks);
                }
            }
			int say = 0;
			while(say<freks.Count){
				frekans ff = freks[say];
				ff.frek= Math.Round((ff.frek / freks.Count), 2);
				if (ff.frek < 0.5)
				{
					freks.Remove(ff);
				}
				say++;
			}
        }
        public void exist_otel(otel h,List<frekans> frekki)
        {
            bool exist = false;
            foreach (frekans fr in frekki)
            {
                if (h.isim.Equals(fr.t.isim))
                {
                    exist = true;
                    fr.frek += 1;
                    break;
                }
            }
            if (exist == false)
            {
                frekki.Add(new frekans(h));
            }
        }
    }
	
    class test
    {


        
        public const string computer_path = "C:\\Users\\Kenan\\Desktop";



        public static Hashtable özellikler_hash = new Hashtable();
        public static Lineer_Hash sehirler;
        public static Chain_Hash specials;

		public static List<sehir> tum_sehirler = new List<sehir>();
        public static List<oda> tum_odalar;
        public static List<turistik> tum_yerler;
        public static List<otel> tum_oteller;
        public static List<kullanıcı> tum_kullan;
        public const string oda_dat = computer_path + "\\data\\odalar.dat";
        public const string otel_dat = computer_path+"\\data\\oteller.dat";
        public const string yer_dat = computer_path + "\\data\\yerler.dat";
        public const string sehir_dat = computer_path + "\\data\\sehirler.dat";
        public const string ozellik_dat = computer_path + "\\data\\ozellikler.dat";
        public const string kullanıcı_dat = computer_path + "\\data\\kullanıcılar.dat";
		public const string apriorisource_dat = computer_path + "\\data\\apriorisource.dat";
        public const string opinion = test.computer_path + "\\görüş.dat";
        public const string possitive = test.computer_path + "\\possitive.dat";
        public const string negative = test.computer_path + "\\negative.dat";
        public static string[] okuma(string filen)
		{
			StreamReader okunan = new StreamReader(filen, System.Text.Encoding.UTF8);
			string icerik = okunan.ReadLine();
			List<string> buff = new List<string>();
			while (icerik != null)
			{
				buff.Add(icerik);
				icerik = okunan.ReadLine();
			}
			string[] cevir = buff.ToArray();
			okunan.Close();
			return cevir;
		}
		public static void yazma(string filen, string[] icerik)
		{
			StreamWriter yazım = new StreamWriter(filen);
			foreach (string s in icerik)
			{
				yazım.WriteLine(s);
			}
			yazım.Close();
		}
        public static List<otel> arama(string sorgu)
        {

            List<otel> otel_sor;
            if (sorgu.ToLower() == "otel")
            {
                otel_sor = tum_oteller;
                return otel_sor;

            }
            
            otel hedef = otel_ara(sorgu);
            sehir s = sehir_ara(sorgu);
            turistik travel = turist_ara(sorgu);
            if (hedef != null)
            {
                otel_sor = new List<otel>();
                otel_sor.Add(hedef);
                return otel_sor;
            }
            else if (turist_ara(sorgu) != null)
            {
                return travel.oteller;
            }
            else if (s != null)
            {
                otel_sor = new List<otel>();
                s.yer_agaci.Uygula(s.yer_agaci.root, otel_sor);
                return otel_sor;
            }
            else if (ozellik_ara(sorgu) != null)
            {
                otel_sor = ozellik_ara(sorgu);
                return otel_sor;
            }
            else
            {
                return null;
            }
        }
        public static sehir sehir_ara(string city)
        {
            sehir citt = null;
            for (int i = 0; i < sehirler.size; i++)
            {
                if (sehirler.table[i] != null)
                {
                    string isim = sehirler.table[i].isim.ToLower();
                    if (isim.Contains(city.ToLower()))
                    {
                        citt = sehirler.table[i];
                        break;
                    }
                }

            }
            return citt;
        }
        public static turistik turist_ara(string goal)
        {
            turistik hedef = null;
            foreach (turistik ot in tum_yerler)
            {
                string isim = ot.isim.ToLower();
                if (isim.Contains(goal.ToLower()))
                {
                    hedef = ot;
                    break;
                }
            }
            return hedef;
        }
        public static List<otel> ozellik_ara(string attribute)
        {
            List<otel> oteller =null;
            ICollection kod = özellikler_hash.Keys;
            foreach(String attr in kod)
            {
                if (attribute.ToLower().Contains(attr.ToLower()))
                {

                    oteller = (List<otel>)özellikler_hash[attr];
                    break;
                }
            }
            return oteller;
        }
        public static otel otel_ara(string a)
        {
            otel hedef = null;
           
            foreach (otel ot in tum_oteller)
            {
                string isim = ot.isim.ToLower();
                if (isim.Contains(a.ToLower()))
                {
                    hedef = ot;
                    break;
                }
            }
            return hedef;
        }
        public static void Baslat()
        {
            
            StreamReader objInput = new StreamReader(oda_dat, System.Text.Encoding.Default);
            string contents = objInput.ReadLine();
            string[] split = Regex.Split(contents, "-", RegexOptions.None);
            tum_odalar = new List<oda>();
            while (contents != null)//ODALARI DAT DAN CEKME

            {
                split = Regex.Split(contents, "-", RegexOptions.None);
                string id = split[0];
                string oda_tip = split[1];
                string[] split2 = split[2].Split('.');
                int yataksay = Convert.ToInt32(split2[0]);
                yataksay--;
                int kapasit = Convert.ToInt32(split2[1]);
                int ucret = Convert.ToInt32(split2[2]);
                tum_odalar.Add(new oda(id, oda_tip, yataksay, kapasit, ucret));
                contents = objInput.ReadLine();
            }

            StreamReader streamr = new StreamReader(otel_dat, System.Text.Encoding.UTF8);//OTELLERİ DAT DAN ÇEKME
            string okuma = streamr.ReadLine();
            string[] splinter = okuma.Split('!');
            tum_oteller = new List<otel>();
            while (okuma != null)
            {
                splinter = okuma.Split('!');
                string isim = splinter[0];
                string[] splint = splinter[1].Split(',');
                string yer = splint[1];
                List<string> bilg = splinter[2].Split(',').ToList();
                string[] arr = splinter[3].Split(',');
                List<oda> otel_oda = new List<oda>();
                foreach (string a in arr)
                {
                    foreach (oda od in tum_odalar)
                    {
                        if (a.Equals(od.id))
                        {
                            otel_oda.Add(od);
                        }
                    }
                }
                okuma = streamr.ReadLine();
                otel yeni = new otel(isim);
                yeni.bilgiler = bilg;
                yeni.odalar = otel_oda;
                yeni.yer_isim = yer;
                foreach (oda sah in yeni.odalar)
                {
                    sah.sahip = yeni;
                }
                tum_oteller.Add(yeni);
            }

            StreamReader stream_yer = new StreamReader(yer_dat, System.Text.Encoding.UTF8);
            string okuma_yer = stream_yer.ReadLine();
            string[] split_yer = okuma_yer.Split('!');
            tum_yerler = new List<turistik>();
            while (okuma_yer != null)
            {
                split_yer = okuma_yer.Split('!');
                string ad = split_yer[0];
                string[] arr1 = split_yer[1].Split(',');
                List<otel> otel_yer = new List<otel>();
                foreach (string a in arr1)
                {
                    foreach (otel ot in tum_oteller)
                    {
                        if (a.Equals(ot.isim))
                        {
                            otel_yer.Add(ot);
                        }
                    }
                }
                turistik yenı_yer = new turistik(ad);
                yenı_yer.oteller = otel_yer;
                tum_yerler.Add(yenı_yer);
                okuma_yer = stream_yer.ReadLine();
            }
            StreamReader sehirici = new StreamReader(sehir_dat, System.Text.Encoding.UTF8);
            string okuma_sehir = sehirici.ReadLine();
            string[] split_s = okuma_sehir.Split('!');
            sehirler = new Lineer_Hash(32);
            while (okuma_sehir != null)
            {
                split_s = okuma_sehir.Split('!');
                string ad1 = split_s[0];
                string[] arr2 = split_s[1].Split(',');
                bintree<turistik> place = new bintree<turistik>();
                foreach (string a in arr2)
                {
                    foreach (turistik tur in tum_yerler)
                    {
                        if (tur.isim.Equals(a))
                        {
                            place.Add(tur);
                        }
                    }
                }
                sehir city = new sehir(ad1);
				place.balance();
                city.yer_agaci = place;
                sehirler.add(city);
				tum_sehirler.Add(city);
                okuma_sehir = sehirici.ReadLine();
            }
            StreamReader ozellik = new StreamReader(ozellik_dat, System.Text.Encoding.UTF8);
            string attreb = ozellik.ReadLine();
            specials = new Chain_Hash(32);
            while (attreb != null)
            {  

                string[] split_oz = attreb.Split('-');
                string oz = split_oz[0];
                string[] split_otel = split_oz[1].Split(',');
                ozellik ekleme = new ozellik(oz);
                List<otel> ek1 = new List<otel>();
                foreach (string a in split_otel)//attribute e  ait otel objelerini alır. ek1 e ekler
                {
                    foreach (otel tel in tum_oteller)
                    {
                        if (tel.isim.Equals(a))
                        {

                            ek1.Add(tel);
                            break;

                        }
                    }
                }
                ekleme.otels = ek1; ;
                specials.Add(ekleme);
                özellikler_hash.Add(oz, ek1);
                attreb = ozellik.ReadLine();

            }
            

            tum_kullan = new List<kullanıcı>();
            StreamReader users = new StreamReader(kullanıcı_dat, System.Text.Encoding.UTF8);
            string kayıt = users.ReadLine();
            while (kayıt != null)
            {
                string[] split_us = kayıt.Split('!');
                string user_info = split_us[0];
                string[] bilgiler = user_info.Split(',');
                if (bilgiler[0].Equals("admin"))
                {
                    admin yonet = new admin(bilgiler[0], bilgiler[1], bilgiler[3], bilgiler[2]);
                    tum_kullan.Add(yonet);
                }
                if (bilgiler[0].Equals("uye"))
                {
                    Üye kullan = new Üye(bilgiler[0], bilgiler[1], bilgiler[3], bilgiler[2]);
                    kullan.cinsiyet = bilgiler[5];
                    kullan.yas = Convert.ToInt32(bilgiler[4]);
                    kullan.meslek = bilgiler[7];
                    kullan.evli = bilgiler[6];
                    kullan.maas = Convert.ToInt32(bilgiler[8]);
                    if (split_us.Length != 1)
                    {
                        string[] split_pas = split_us[1].Split(',');
                        foreach (string a in split_pas)
                        {
                            foreach (oda od in tum_odalar)
                            {
                                if (od.id.Equals(a))
                                {
                                    kullan.rezervasyonlar.Add(od);
                                }
                            }
                        }
                    }
                    tum_kullan.Add(kullan);
                }

                kayıt = users.ReadLine();
            }
			string[] oku_rez = test.okuma(apriorisource_dat);
			for(int i=0;i<oku_rez.Length;i++){
				string[] ekk = oku_rez[i].Split(',');
				foreach(kullanıcı kal in tum_kullan){
					if(kal.Kullanıcı_adı.Equals(ekk[0])){
						Üye k = (Üye)kal;
						foreach(oda room in tum_odalar){
							if(room.id.Equals(ekk[1])){
								admin.kar += room.fiyat;
								k.rezervasyonlar.Add(room);
							}
						}
					}
				}
			}
			tum_kullan.First();
		}
    }
    static class Program
    {
        
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
			
            test.Baslat();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(test.sehirler, test.specials));
           
            
        }
    }
}
