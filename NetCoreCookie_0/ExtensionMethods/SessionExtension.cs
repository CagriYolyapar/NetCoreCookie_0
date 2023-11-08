using Newtonsoft.Json;

namespace NetCoreCookie_0.ExtensionMethods
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session,string key, object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key,objectString);
        }


        public static T GetObject<T>(this ISession session,string key) where T:class
        {
            string objectString = session.GetString(key);
            if(string.IsNullOrEmpty(objectString))
            {
                return null;
            }
            T deserializedObject = JsonConvert.DeserializeObject<T>(objectString);
            return deserializedObject;

        }
    }
}





/*
 
 Siparis
{
   string SiparisAdresi(property)
   string SiparisNo(property)

}


-----JSON(Javascript object notation) String

--Serialize (JsonSerialization)
{
  "SiparisAdresi" : "Barbaros Mah. vs vs vs ",
  "SiparisNo" : "123"

}



--Deserialization

Siparis
{

    string SiparisAdresi
    string   SiparisNo
}

 
 
 
 
 */
