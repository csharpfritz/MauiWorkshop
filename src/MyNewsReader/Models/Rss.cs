using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewsReader.Models;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(ElementName = "rss")]
public partial class Rss {

	private rssChannel channelField;

	private decimal versionField;

	/// <remarks/>
	public rssChannel channel {
		get {
			return this.channelField;
		}
		set {
			this.channelField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public decimal version {
		get {
			return this.versionField;
		}
		set {
			this.versionField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannel {

	private string titleField;

	private link linkField;

	private string link1Field;

	private string descriptionField;

	private string lastBuildDateField;

	private string languageField;

	private string updatePeriodField;

	private byte updateFrequencyField;

	private string generatorField;

	private rssChannelImage imageField;

	private rssChannelItem[] itemField;

	/// <remarks/>
	public string title {
		get {
			return this.titleField;
		}
		set {
			this.titleField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2005/Atom")]
	public link link {
		get {
			return this.linkField;
		}
		set {
			this.linkField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("link")]
	public string link1 {
		get {
			return this.link1Field;
		}
		set {
			this.link1Field = value;
		}
	}

	/// <remarks/>
	public string description {
		get {
			return this.descriptionField;
		}
		set {
			this.descriptionField = value;
		}
	}

	/// <remarks/>
	public string lastBuildDate {
		get {
			return this.lastBuildDateField;
		}
		set {
			this.lastBuildDateField = value;
		}
	}

	/// <remarks/>
	public string language {
		get {
			return this.languageField;
		}
		set {
			this.languageField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/rss/1.0/modules/syndication/")]
	public string updatePeriod {
		get {
			return this.updatePeriodField;
		}
		set {
			this.updatePeriodField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/rss/1.0/modules/syndication/")]
	public byte updateFrequency {
		get {
			return this.updateFrequencyField;
		}
		set {
			this.updateFrequencyField = value;
		}
	}

	/// <remarks/>
	public string generator {
		get {
			return this.generatorField;
		}
		set {
			this.generatorField = value;
		}
	}

	/// <remarks/>
	public rssChannelImage image {
		get {
			return this.imageField;
		}
		set {
			this.imageField = value;
		}
	}

	public bool ImageIsVisible => !string.IsNullOrEmpty(image?.url);

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("item")]
	public rssChannelItem[] item {
		get {
			return this.itemField;
		}
		set {
			this.itemField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
public partial class link {

	private string hrefField;

	private string relField;

	private string typeField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string href {
		get {
			return this.hrefField;
		}
		set {
			this.hrefField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string rel {
		get {
			return this.relField;
		}
		set {
			this.relField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public string type {
		get {
			return this.typeField;
		}
		set {
			this.typeField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannelImage {

	private string urlField;

	private string titleField;

	private string linkField;

	private byte widthField;

	private byte heightField;

	/// <remarks/>
	public string url {
		get {
			return this.urlField;
		}
		set {
			this.urlField = value;
		}
	}

	/// <remarks/>
	public string title {
		get {
			return this.titleField;
		}
		set {
			this.titleField = value;
		}
	}

	/// <remarks/>
	public string link {
		get {
			return this.linkField;
		}
		set {
			this.linkField = value;
		}
	}

	/// <remarks/>
	public byte width {
		get {
			return this.widthField;
		}
		set {
			this.widthField = value;
		}
	}

	/// <remarks/>
	public byte height {
		get {
			return this.heightField;
		}
		set {
			this.heightField = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannelItem {

	private string titleField;

	private string linkField;

	private string commentsField;

	private string creatorField;

	private string pubDateField;

	private string[] categoryField;

	private rssChannelItemGuid guidField;

	private string descriptionField;

	private string encodedField;

	private string commentRssField;

	private byte comments1Field;

	/// <remarks/>
	public string title {
		get {
			return this.titleField;
		}
		set {
			this.titleField = value;
		}
	}

	/// <remarks/>
	public string link {
		get {
			return this.linkField;
		}
		set {
			this.linkField = value;
		}
	}

	/// <remarks/>
	public string comments {
		get {
			return this.commentsField;
		}
		set {
			this.commentsField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/elements/1.1/")]
	public string creator {
		get {
			return this.creatorField;
		}
		set {
			this.creatorField = value;
		}
	}

	/// <remarks/>
	public string pubDate {
		get {
			return this.pubDateField;
		}
		set {
			this.pubDateField = value;
		}
	}

	public DateTimeOffset PublicationDate => DateTimeOffset.Parse(pubDate);

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("category")]
	public string[] category {
		get {
			return this.categoryField;
		}
		set {
			this.categoryField = value;
		}
	}

	/// <remarks/>
	public rssChannelItemGuid guid {
		get {
			return this.guidField;
		}
		set {
			this.guidField = value;
		}
	}

	/// <remarks/>
	public string description {
		get {
			return this.descriptionField;
		}
		set {
			this.descriptionField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/rss/1.0/modules/content/")]
	public string encoded {
		get {
			return this.encodedField;
		}
		set {
			this.encodedField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://wellformedweb.org/CommentAPI/")]
	public string commentRss {
		get {
			return this.commentRssField;
		}
		set {
			this.commentRssField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlElementAttribute("comments", Namespace = "http://purl.org/rss/1.0/modules/slash/")]
	public byte comments1 {
		get {
			return this.comments1Field;
		}
		set {
			this.comments1Field = value;
		}
	}
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rssChannelItemGuid {

	private bool isPermaLinkField;

	private string valueField;

	/// <remarks/>
	[System.Xml.Serialization.XmlAttributeAttribute()]
	public bool isPermaLink {
		get {
			return this.isPermaLinkField;
		}
		set {
			this.isPermaLinkField = value;
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTextAttribute()]
	public string Value {
		get {
			return this.valueField;
		}
		set {
			this.valueField = value;
		}
	}
}



