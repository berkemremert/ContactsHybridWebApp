using System;
using System.Text.Json;
using ContactsHybridWebApp.Models;

namespace ContactsHybridWebApp.Services;

public class ContactService
{
    string file = string.Empty;

    public ContactService(){
        file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "contacts.json");
    }

    public void SaveContacts(IEnumerable<SimpleContact> contacts){
        File.WriteAllText(file, JsonSerializer.Serialize(contacts));
    }

    public IEnumerable<SimpleContact> LoadContacts(){
        if(!File.Exists(file)){
            return Enumerable.Empty<SimpleContact>();
        }

        var contactJson = File.ReadAllText(file);
        return JsonSerializer.Deserialize<IEnumerable<SimpleContact>>(contactJson) ?? Enumerable.Empty<SimpleContact>();
    }
}
