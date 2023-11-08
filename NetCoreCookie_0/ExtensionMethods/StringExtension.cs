namespace NetCoreCookie_0.ExtensionMethods
{
    //Extension methodlar bir static class icerisinde olmak zorundadır.

    //Extension metotlar sayesinde siz istediginiz bir tipe istediginiz şekilde bir metot inject edebilirsiniz
    public static class StringExtension
    {
        //Bir metodun extension metot olabilmesi icin ilk parametresini cok özel alması gerekir. Bu ilk parametre verilirken this keyword'u ile baslanmalıdır..Ve ilgili metodu hangi tipe enjekte etmek istiyorsanız o tipte bir parametre olması gereklidir...
        public static string Sekillendir(this string injection)
        {
            return "Merhaba ben sekillendirildim";
        }
    }
}
