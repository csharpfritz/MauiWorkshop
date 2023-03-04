using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewsReader.Models;

/// <param name="SourceUrl"></param>
/// <param name="Title"></param>
public record NewsFeed(string SourceUrl, string Title) {
	public NewsFeed() : this(string.Empty, string.Empty) {
	}
}
