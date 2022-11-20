#pragma warning disable CS8618
namespace Shared;

// auto generated classes, hand cleaned up and modified

public class Description
{
	public Url_[] Urls { get; set; }
}

public class Entities
{
	public Description   Description  { get; set; }
	public Url_          Url          { get; set; }
	public Hashtag[]     Hashtags     { get; set; }
	public object[]      Symbols      { get; set; }
	public Url_[]        Urls         { get; set; }
	public UserMention[] UserMentions { get; set; }
	public Medium[]      Media        { get; set; }
}

public class Hashtag
{
	public string Text    { get; set; }
	public int[]  Indices { get; set; }
}

public class Large
{
	public int    W      { get; set; }
	public int    H      { get; set; }
	public string Resize { get; set; }
}

public class Medium
{
	public object Id                { get; set; }
	public string IdStr             { get; set; }
	public int[]  Indices           { get; set; }
	public string MediaUrl          { get; set; }
	public string MediaUrlHttps     { get; set; }
	public string Url               { get; set; }
	public string DisplayUrl        { get; set; }
	public string ExpandedUrl       { get; set; }
	public string Type              { get; set; }
	public Sizes  Sizes             { get; set; }
	public object SourceStatusId    { get; set; }
	public string SourceStatusIdStr { get; set; }
}

public class Medium2
{
	public int    W      { get; set; }
	public int    H      { get; set; }
	public string Resize { get; set; }
}

public class Metadata
{
	public string ResultType      { get; set; }
	public string IsoLanguageCode { get; set; }
}

public class RetweetedStatus
{
	public Metadata Metadata             { get; set; }
	public string   CreatedAt            { get; set; }
	public object   Id                   { get; set; }
	public string   IdStr                { get; set; }
	public string   Text                 { get; set; }
	public string   Source               { get; set; }
	public bool     Truncated            { get; set; }
	public long?    InReplyToStatusId    { get; set; }
	public string   InReplyToStatusIdStr { get; set; }
	public long?    InReplyToUserId      { get; set; }
	public string   InReplyToUserIdStr   { get; set; }
	public string   InReplyToScreenName  { get; set; }
	public User     User                 { get; set; }
	public object   Geo                  { get; set; }
	public object   Coordinates          { get; set; }
	public object   Place                { get; set; }
	public object   Contributors         { get; set; }
	public int      RetweetCount         { get; set; }
	public int      FavoriteCount        { get; set; }
	public Entities Entities             { get; set; }
	public bool     Favorited            { get; set; }
	public bool     Retweeted            { get; set; }
	public bool     PossiblySensitive    { get; set; }
	public string   Lang                 { get; set; }
}

public class Root
{
	public Status[]       Statuses       { get; set; }
	public SearchMetadata SearchMetadata { get; set; }
}

public class SearchMetadata
{
	public double CompletedIn { get; set; }
	public long   MaxId       { get; set; }
	public string MaxIdStr    { get; set; }
	public string NextResults { get; set; }
	public string Query       { get; set; }
	public string RefreshUrl  { get; set; }
	public int    Count       { get; set; }
	public int    SinceId     { get; set; }
	public string SinceIdStr  { get; set; }
}

public class Sizes
{
	public Medium Medium { get; set; }
	public Small  Small  { get; set; }
	public Thumb  Thumb  { get; set; }
	public Large  Large  { get; set; }
}

public class Small
{
	public int    W      { get; set; }
	public int    H      { get; set; }
	public string Resize { get; set; }
}

public class Status
{
	public Metadata        Metadata             { get; set; }
	public string          CreatedAt            { get; set; }
	public object          Id                   { get; set; }
	public string          IdStr                { get; set; }
	public string          Text                 { get; set; }
	public string          Source               { get; set; }
	public bool            Truncated            { get; set; }
	public long?           InReplyToStatusId    { get; set; }
	public string          InReplyToStatusIdStr { get; set; }
	public long?           InReplyToUserId      { get; set; }
	public string          InReplyToUserIdStr   { get; set; }
	public string          InReplyToScreenName  { get; set; }
	public User            User                 { get; set; }
	public object          Geo                  { get; set; }
	public object          Coordinates          { get; set; }
	public object          Place                { get; set; }
	public object          Contributors         { get; set; }
	public int             RetweetCount         { get; set; }
	public int             FavoriteCount        { get; set; }
	public Entities        Entities             { get; set; }
	public bool            Favorited            { get; set; }
	public bool            Retweeted            { get; set; }
	public string          Lang                 { get; set; }
	public RetweetedStatus RetweetedStatus      { get; set; }
	public bool?           PossiblySensitive    { get; set; }
}

public class Thumb
{
	public int    W      { get; set; }
	public int    H      { get; set; }
	public string Resize { get; set; }
}

public class Url_
{
	public string Url         { get; set; }
	public string ExpandedUrl { get; set; }
	public string DisplayUrl  { get; set; }
	public int[]  Indices     { get; set; }
}

public class Url2
{
	public Url_[] Urls { get; set; }
}

public class User
{
	public object   Id                             { get; set; }
	public string   IdStr                          { get; set; }
	public string   Name                           { get; set; }
	public string   ScreenName                     { get; set; }
	public string   Location                       { get; set; }
	public string   Description                    { get; set; }
	public string   Url                            { get; set; }
	public Entities Entities                       { get; set; }
	public bool     Protected                      { get; set; }
	public int      FollowersCount                 { get; set; }
	public int      FriendsCount                   { get; set; }
	public int      ListedCount                    { get; set; }
	public string   CreatedAt                      { get; set; }
	public int      FavouritesCount                { get; set; }
	public int?     UtcOffset                      { get; set; }
	public string   TimeZone                       { get; set; }
	public bool     GeoEnabled                     { get; set; }
	public bool     Verified                       { get; set; }
	public int      StatusesCount                  { get; set; }
	public string   Lang                           { get; set; }
	public bool     ContributorsEnabled            { get; set; }
	public bool     IsTranslator                   { get; set; }
	public bool     IsTranslationEnabled           { get; set; }
	public string   ProfileBackgroundColor         { get; set; }
	public string   ProfileBackgroundImageUrl      { get; set; }
	public string   ProfileBackgroundImageUrlHttps { get; set; }
	public bool     ProfileBackgroundTile          { get; set; }
	public string   ProfileImageUrl                { get; set; }
	public string   ProfileImageUrlHttps           { get; set; }
	public string   ProfileBannerUrl               { get; set; }
	public string   ProfileLinkColor               { get; set; }
	public string   ProfileSidebarBorderColor      { get; set; }
	public string   ProfileSidebarFillColor        { get; set; }
	public string   ProfileTextColor               { get; set; }
	public bool     ProfileUseBackgroundImage      { get; set; }
	public bool     DefaultProfile                 { get; set; }
	public bool     DefaultProfileImage            { get; set; }
	public bool     Following                      { get; set; }
	public bool     FollowRequestSent              { get; set; }
	public bool     Notifications                  { get; set; }
}

public class UserMention
{
	public string ScreenName { get; set; }
	public string Name       { get; set; }
	public object Id         { get; set; }
	public string IdStr      { get; set; }
	public int[]  Indices    { get; set; }
}