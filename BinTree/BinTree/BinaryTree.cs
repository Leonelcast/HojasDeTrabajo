
using System.Linq;

public class BinaryTree : IBinTree{
    public int Valor {get;}

    public IBinTree Derecho { get; set; }

    public IBinTree Izquierdo { get; set; }

    public BinaryTree(int valor, IBinTree derecho, IBinTree izquierdo){
        this.Valor = valor;
        this.Derecho = derecho;
        this.Izquierdo = izquierdo;
    }

    public BinaryTree(int valor){
        this.Valor = valor;
    }

    public override string ToString(){
        string derecho = this.Derecho == null ? string.Empty : this.Derecho.ToString();
        string izquierdo = this.Izquierdo == null ? string.Empty : this.Izquierdo.ToString();

        return $"{this.Valor} \n\t {derecho} \n\t {izquierdo}";
    }

    public int Sumar()
    {
        int sumaIzq = this.Izquierdo == null ? 0 : this.Izquierdo.Sumar();
        int sumaDer = this.Derecho == null ? 0 : this.Derecho.Sumar();

        return sumaDer + sumaIzq + this.Valor;
    }

    public int[] ToArray()
    {
        var temp = new int[0];
        int[] total = new int[0];
        if (this.Izquierdo != null)
        {
            var izquierdoArr = Izquierdo.ToArray();
            total = izquierdoArr;
        }

        temp = new int[total.Length + 1];
        total.CopyTo(temp, 0);
        var valorArr = new int[] { this.Valor };
        valorArr.CopyTo(temp, total.Length);
        total = temp;

        if (this.Derecho != null)
        {
            var derechoArr = Derecho.ToArray();
            temp = new int[derechoArr.Length + total.Length];
            total.CopyTo(temp, 0);
            derechoArr.CopyTo(temp, total.Length);
        }

        total = temp;

        return total;
    }

    public void Insert(int valor)
    {
        if (valor <= this.Valor)
        {
            if (Izquierdo == null)
            {
                this.Izquierdo = new BinaryTree(valor);
            } else
            {
                Izquierdo.Insert(valor);
            }
        } else
        {
            if (Derecho == null)
                this.Derecho = new BinaryTree(valor);
            else
                Derecho.Insert(valor);
        }
    }
}