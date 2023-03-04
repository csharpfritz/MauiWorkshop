using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyNewsReader.Models;


public partial class Rss {
	
static XmlSerializer _Serializer = new XmlSerializer(typeof(Rss));
	public static Rss Deserialize(string xml) {

		return (Rss)_Serializer.Deserialize(new System.IO.StringReader(xml));

	}

}