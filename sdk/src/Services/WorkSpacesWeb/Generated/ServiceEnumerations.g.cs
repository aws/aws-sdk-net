/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.WorkSpacesWeb
{
    /// <summary>
    /// Constants used for properties of type AuthenticationType.
    /// </summary>
    public class AuthenticationType : ConstantClass
    {
        /// <summary>
        /// Constant IAM_Identity_Center for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType IAM_Identity_Center = new AuthenticationType("IAM_Identity_Center");

        /// <summary>
        /// Constant Standard for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType Standard = new AuthenticationType("Standard");

        /// <summary>
        /// Constructs a custom AuthenticationType for a value not among the defined constants.
        /// </summary>
        public AuthenticationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationType FindValue(string value)
        {
            return FindValue<AuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BrowserType.
    /// </summary>
    public class BrowserType : ConstantClass
    {
        /// <summary>
        /// Constant Chrome for BrowserType
        /// </summary>
        public static readonly BrowserType Chrome = new BrowserType("Chrome");

        /// <summary>
        /// Constructs a custom BrowserType for a value not among the defined constants.
        /// </summary>
        public BrowserType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserType FindValue(string value)
        {
            return FindValue<BrowserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Category.
    /// </summary>
    public class Category : ConstantClass
    {
        /// <summary>
        /// Constant Chat for Category
        /// </summary>
        public static readonly Category Chat = new Category("Chat");

        /// <summary>
        /// Constant CriminalActivity for Category
        /// </summary>
        public static readonly Category CriminalActivity = new Category("CriminalActivity");

        /// <summary>
        /// Constant Cults for Category
        /// </summary>
        public static readonly Category Cults = new Category("Cults");

        /// <summary>
        /// Constant DownloadSites for Category
        /// </summary>
        public static readonly Category DownloadSites = new Category("DownloadSites");

        /// <summary>
        /// Constant Gambling for Category
        /// </summary>
        public static readonly Category Gambling = new Category("Gambling");

        /// <summary>
        /// Constant Games for Category
        /// </summary>
        public static readonly Category Games = new Category("Games");

        /// <summary>
        /// Constant GenerativeAI for Category
        /// </summary>
        public static readonly Category GenerativeAI = new Category("GenerativeAI");

        /// <summary>
        /// Constant Hacking for Category
        /// </summary>
        public static readonly Category Hacking = new Category("Hacking");

        /// <summary>
        /// Constant HateAndIntolerance for Category
        /// </summary>
        public static readonly Category HateAndIntolerance = new Category("HateAndIntolerance");

        /// <summary>
        /// Constant IllegalDrug for Category
        /// </summary>
        public static readonly Category IllegalDrug = new Category("IllegalDrug");

        /// <summary>
        /// Constant IllegalSoftware for Category
        /// </summary>
        public static readonly Category IllegalSoftware = new Category("IllegalSoftware");

        /// <summary>
        /// Constant ImageSharing for Category
        /// </summary>
        public static readonly Category ImageSharing = new Category("ImageSharing");

        /// <summary>
        /// Constant InstantMessaging for Category
        /// </summary>
        public static readonly Category InstantMessaging = new Category("InstantMessaging");

        /// <summary>
        /// Constant Nudity for Category
        /// </summary>
        public static readonly Category Nudity = new Category("Nudity");

        /// <summary>
        /// Constant ParkedDomains for Category
        /// </summary>
        public static readonly Category ParkedDomains = new Category("ParkedDomains");

        /// <summary>
        /// Constant PeerToPeer for Category
        /// </summary>
        public static readonly Category PeerToPeer = new Category("PeerToPeer");

        /// <summary>
        /// Constant Pornography for Category
        /// </summary>
        public static readonly Category Pornography = new Category("Pornography");

        /// <summary>
        /// Constant ProfessionalNetwork for Category
        /// </summary>
        public static readonly Category ProfessionalNetwork = new Category("ProfessionalNetwork");

        /// <summary>
        /// Constant SchoolCheating for Category
        /// </summary>
        public static readonly Category SchoolCheating = new Category("SchoolCheating");

        /// <summary>
        /// Constant SelfHarm for Category
        /// </summary>
        public static readonly Category SelfHarm = new Category("SelfHarm");

        /// <summary>
        /// Constant SexEducation for Category
        /// </summary>
        public static readonly Category SexEducation = new Category("SexEducation");

        /// <summary>
        /// Constant SocialNetworking for Category
        /// </summary>
        public static readonly Category SocialNetworking = new Category("SocialNetworking");

        /// <summary>
        /// Constant StreamingMediaAndDownloads for Category
        /// </summary>
        public static readonly Category StreamingMediaAndDownloads = new Category("StreamingMediaAndDownloads");

        /// <summary>
        /// Constant Tasteless for Category
        /// </summary>
        public static readonly Category Tasteless = new Category("Tasteless");

        /// <summary>
        /// Constant Violence for Category
        /// </summary>
        public static readonly Category Violence = new Category("Violence");

        /// <summary>
        /// Constant Weapons for Category
        /// </summary>
        public static readonly Category Weapons = new Category("Weapons");

        /// <summary>
        /// Constant WebBasedEmail for Category
        /// </summary>
        public static readonly Category WebBasedEmail = new Category("WebBasedEmail");

        /// <summary>
        /// Constructs a custom Category for a value not among the defined constants.
        /// </summary>
        public Category(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Category FindValue(string value)
        {
            return FindValue<Category>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Category(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ColorTheme.
    /// </summary>
    public class ColorTheme : ConstantClass
    {
        /// <summary>
        /// Constant Dark for ColorTheme
        /// </summary>
        public static readonly ColorTheme Dark = new ColorTheme("Dark");

        /// <summary>
        /// Constant Light for ColorTheme
        /// </summary>
        public static readonly ColorTheme Light = new ColorTheme("Light");

        /// <summary>
        /// Constructs a custom ColorTheme for a value not among the defined constants.
        /// </summary>
        public ColorTheme(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColorTheme FindValue(string value)
        {
            return FindValue<ColorTheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColorTheme(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type EnabledType.
    /// </summary>
    public class EnabledType : ConstantClass
    {
        /// <summary>
        /// Constant Disabled for EnabledType
        /// </summary>
        public static readonly EnabledType Disabled = new EnabledType("Disabled");

        /// <summary>
        /// Constant Enabled for EnabledType
        /// </summary>
        public static readonly EnabledType Enabled = new EnabledType("Enabled");

        /// <summary>
        /// Constructs a custom EnabledType for a value not among the defined constants.
        /// </summary>
        public EnabledType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnabledType FindValue(string value)
        {
            return FindValue<EnabledType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnabledType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Event.
    /// </summary>
    public class Event : ConstantClass
    {
        /// <summary>
        /// Constant ContentCopyFromWebsite for Event
        /// </summary>
        public static readonly Event ContentCopyFromWebsite = new Event("ContentCopyFromWebsite");

        /// <summary>
        /// Constant ContentPasteToWebsite for Event
        /// </summary>
        public static readonly Event ContentPasteToWebsite = new Event("ContentPasteToWebsite");

        /// <summary>
        /// Constant ContentTransferFromLocalToRemoteClipboard for Event
        /// </summary>
        public static readonly Event ContentTransferFromLocalToRemoteClipboard = new Event("ContentTransferFromLocalToRemoteClipboard");

        /// <summary>
        /// Constant FileDownloadFromSecureBrowserToRemoteDisk for Event
        /// </summary>
        public static readonly Event FileDownloadFromSecureBrowserToRemoteDisk = new Event("FileDownloadFromSecureBrowserToRemoteDisk");

        /// <summary>
        /// Constant FileTransferFromLocalToRemoteDisk for Event
        /// </summary>
        public static readonly Event FileTransferFromLocalToRemoteDisk = new Event("FileTransferFromLocalToRemoteDisk");

        /// <summary>
        /// Constant FileTransferFromRemoteToLocalDisk for Event
        /// </summary>
        public static readonly Event FileTransferFromRemoteToLocalDisk = new Event("FileTransferFromRemoteToLocalDisk");

        /// <summary>
        /// Constant FileUploadFromRemoteDiskToSecureBrowser for Event
        /// </summary>
        public static readonly Event FileUploadFromRemoteDiskToSecureBrowser = new Event("FileUploadFromRemoteDiskToSecureBrowser");

        /// <summary>
        /// Constant PrintJobSubmit for Event
        /// </summary>
        public static readonly Event PrintJobSubmit = new Event("PrintJobSubmit");

        /// <summary>
        /// Constant SessionConnect for Event
        /// </summary>
        public static readonly Event SessionConnect = new Event("SessionConnect");

        /// <summary>
        /// Constant SessionDisconnect for Event
        /// </summary>
        public static readonly Event SessionDisconnect = new Event("SessionDisconnect");

        /// <summary>
        /// Constant SessionEnd for Event
        /// </summary>
        public static readonly Event SessionEnd = new Event("SessionEnd");

        /// <summary>
        /// Constant SessionStart for Event
        /// </summary>
        public static readonly Event SessionStart = new Event("SessionStart");

        /// <summary>
        /// Constant TabClose for Event
        /// </summary>
        public static readonly Event TabClose = new Event("TabClose");

        /// <summary>
        /// Constant TabOpen for Event
        /// </summary>
        public static readonly Event TabOpen = new Event("TabOpen");

        /// <summary>
        /// Constant UrlBlockByContentFilter for Event
        /// </summary>
        public static readonly Event UrlBlockByContentFilter = new Event("UrlBlockByContentFilter");

        /// <summary>
        /// Constant UrlLoad for Event
        /// </summary>
        public static readonly Event UrlLoad = new Event("UrlLoad");

        /// <summary>
        /// Constant WebsiteInteract for Event
        /// </summary>
        public static readonly Event WebsiteInteract = new Event("WebsiteInteract");

        /// <summary>
        /// Constructs a custom Event for a value not among the defined constants.
        /// </summary>
        public Event(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Event FindValue(string value)
        {
            return FindValue<Event>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Event(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FolderStructure.
    /// </summary>
    public class FolderStructure : ConstantClass
    {
        /// <summary>
        /// Constant Flat for FolderStructure
        /// </summary>
        public static readonly FolderStructure Flat = new FolderStructure("Flat");

        /// <summary>
        /// Constant NestedByDate for FolderStructure
        /// </summary>
        public static readonly FolderStructure NestedByDate = new FolderStructure("NestedByDate");

        /// <summary>
        /// Constructs a custom FolderStructure for a value not among the defined constants.
        /// </summary>
        public FolderStructure(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FolderStructure FindValue(string value)
        {
            return FindValue<FolderStructure>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FolderStructure(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type IdentityProviderType.
    /// </summary>
    public class IdentityProviderType : ConstantClass
    {
        /// <summary>
        /// Constant Facebook for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType Facebook = new IdentityProviderType("Facebook");

        /// <summary>
        /// Constant Google for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType Google = new IdentityProviderType("Google");

        /// <summary>
        /// Constant LoginWithAmazon for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType LoginWithAmazon = new IdentityProviderType("LoginWithAmazon");

        /// <summary>
        /// Constant OIDC for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType OIDC = new IdentityProviderType("OIDC");

        /// <summary>
        /// Constant SAML for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType SAML = new IdentityProviderType("SAML");

        /// <summary>
        /// Constant SignInWithApple for IdentityProviderType
        /// </summary>
        public static readonly IdentityProviderType SignInWithApple = new IdentityProviderType("SignInWithApple");

        /// <summary>
        /// Constructs a custom IdentityProviderType for a value not among the defined constants.
        /// </summary>
        public IdentityProviderType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityProviderType FindValue(string value)
        {
            return FindValue<IdentityProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityProviderType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InstanceType.
    /// </summary>
    public class InstanceType : ConstantClass
    {
        /// <summary>
        /// Constant StandardLarge for InstanceType
        /// </summary>
        public static readonly InstanceType StandardLarge = new InstanceType("standard.large");

        /// <summary>
        /// Constant StandardRegular for InstanceType
        /// </summary>
        public static readonly InstanceType StandardRegular = new InstanceType("standard.regular");

        /// <summary>
        /// Constant StandardXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType StandardXlarge = new InstanceType("standard.xlarge");

        /// <summary>
        /// Constructs a custom InstanceType for a value not among the defined constants.
        /// </summary>
        public InstanceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceType FindValue(string value)
        {
            return FindValue<InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Locale.
    /// </summary>
    public class Locale : ConstantClass
    {
        /// <summary>
        /// Constant DeDE for Locale
        /// </summary>
        public static readonly Locale DeDE = new Locale("de-DE");

        /// <summary>
        /// Constant EnUS for Locale
        /// </summary>
        public static readonly Locale EnUS = new Locale("en-US");

        /// <summary>
        /// Constant EsES for Locale
        /// </summary>
        public static readonly Locale EsES = new Locale("es-ES");

        /// <summary>
        /// Constant FrFR for Locale
        /// </summary>
        public static readonly Locale FrFR = new Locale("fr-FR");

        /// <summary>
        /// Constant IdID for Locale
        /// </summary>
        public static readonly Locale IdID = new Locale("id-ID");

        /// <summary>
        /// Constant ItIT for Locale
        /// </summary>
        public static readonly Locale ItIT = new Locale("it-IT");

        /// <summary>
        /// Constant JaJP for Locale
        /// </summary>
        public static readonly Locale JaJP = new Locale("ja-JP");

        /// <summary>
        /// Constant KoKR for Locale
        /// </summary>
        public static readonly Locale KoKR = new Locale("ko-KR");

        /// <summary>
        /// Constant PtBR for Locale
        /// </summary>
        public static readonly Locale PtBR = new Locale("pt-BR");

        /// <summary>
        /// Constant ZhCN for Locale
        /// </summary>
        public static readonly Locale ZhCN = new Locale("zh-CN");

        /// <summary>
        /// Constant ZhTW for Locale
        /// </summary>
        public static readonly Locale ZhTW = new Locale("zh-TW");

        /// <summary>
        /// Constructs a custom Locale for a value not among the defined constants.
        /// </summary>
        public Locale(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Locale FindValue(string value)
        {
            return FindValue<Locale>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Locale(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type LogFileFormat.
    /// </summary>
    public class LogFileFormat : ConstantClass
    {
        /// <summary>
        /// Constant JSONLines for LogFileFormat
        /// </summary>
        public static readonly LogFileFormat JSONLines = new LogFileFormat("JSONLines");

        /// <summary>
        /// Constant Json for LogFileFormat
        /// </summary>
        public static readonly LogFileFormat Json = new LogFileFormat("Json");

        /// <summary>
        /// Constructs a custom LogFileFormat for a value not among the defined constants.
        /// </summary>
        public LogFileFormat(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogFileFormat FindValue(string value)
        {
            return FindValue<LogFileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogFileFormat(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MaxDisplayResolution.
    /// </summary>
    public class MaxDisplayResolution : ConstantClass
    {
        /// <summary>
        /// Constant Size1024X768 for MaxDisplayResolution
        /// </summary>
        public static readonly MaxDisplayResolution Size1024X768 = new MaxDisplayResolution("size1024X768");

        /// <summary>
        /// Constant Size1280X720 for MaxDisplayResolution
        /// </summary>
        public static readonly MaxDisplayResolution Size1280X720 = new MaxDisplayResolution("size1280X720");

        /// <summary>
        /// Constant Size1920X1080 for MaxDisplayResolution
        /// </summary>
        public static readonly MaxDisplayResolution Size1920X1080 = new MaxDisplayResolution("size1920X1080");

        /// <summary>
        /// Constant Size2560X1440 for MaxDisplayResolution
        /// </summary>
        public static readonly MaxDisplayResolution Size2560X1440 = new MaxDisplayResolution("size2560X1440");

        /// <summary>
        /// Constant Size3440X1440 for MaxDisplayResolution
        /// </summary>
        public static readonly MaxDisplayResolution Size3440X1440 = new MaxDisplayResolution("size3440X1440");

        /// <summary>
        /// Constant Size3840X2160 for MaxDisplayResolution
        /// </summary>
        public static readonly MaxDisplayResolution Size3840X2160 = new MaxDisplayResolution("size3840X2160");

        /// <summary>
        /// Constant Size4096X2160 for MaxDisplayResolution
        /// </summary>
        public static readonly MaxDisplayResolution Size4096X2160 = new MaxDisplayResolution("size4096X2160");

        /// <summary>
        /// Constant Size800X600 for MaxDisplayResolution
        /// </summary>
        public static readonly MaxDisplayResolution Size800X600 = new MaxDisplayResolution("size800X600");

        /// <summary>
        /// Constructs a custom MaxDisplayResolution for a value not among the defined constants.
        /// </summary>
        public MaxDisplayResolution(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaxDisplayResolution FindValue(string value)
        {
            return FindValue<MaxDisplayResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaxDisplayResolution(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MimeType.
    /// </summary>
    public class MimeType : ConstantClass
    {
        /// <summary>
        /// Constant ImageJpeg for MimeType
        /// </summary>
        public static readonly MimeType ImageJpeg = new MimeType("image/jpeg");

        /// <summary>
        /// Constant ImagePng for MimeType
        /// </summary>
        public static readonly MimeType ImagePng = new MimeType("image/png");

        /// <summary>
        /// Constant ImageXIcon for MimeType
        /// </summary>
        public static readonly MimeType ImageXIcon = new MimeType("image/x-icon");

        /// <summary>
        /// Constructs a custom MimeType for a value not among the defined constants.
        /// </summary>
        public MimeType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MimeType FindValue(string value)
        {
            return FindValue<MimeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MimeType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type PortalStatus.
    /// </summary>
    public class PortalStatus : ConstantClass
    {
        /// <summary>
        /// Constant Active for PortalStatus
        /// </summary>
        public static readonly PortalStatus Active = new PortalStatus("Active");

        /// <summary>
        /// Constant Incomplete for PortalStatus
        /// </summary>
        public static readonly PortalStatus Incomplete = new PortalStatus("Incomplete");

        /// <summary>
        /// Constant Pending for PortalStatus
        /// </summary>
        public static readonly PortalStatus Pending = new PortalStatus("Pending");

        /// <summary>
        /// Constructs a custom PortalStatus for a value not among the defined constants.
        /// </summary>
        public PortalStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortalStatus FindValue(string value)
        {
            return FindValue<PortalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortalStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RedactionPlaceHolderType.
    /// </summary>
    public class RedactionPlaceHolderType : ConstantClass
    {
        /// <summary>
        /// Constant CustomText for RedactionPlaceHolderType
        /// </summary>
        public static readonly RedactionPlaceHolderType CustomText = new RedactionPlaceHolderType("CustomText");

        /// <summary>
        /// Constructs a custom RedactionPlaceHolderType for a value not among the defined constants.
        /// </summary>
        public RedactionPlaceHolderType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedactionPlaceHolderType FindValue(string value)
        {
            return FindValue<RedactionPlaceHolderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedactionPlaceHolderType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RendererType.
    /// </summary>
    public class RendererType : ConstantClass
    {
        /// <summary>
        /// Constant AppStream for RendererType
        /// </summary>
        public static readonly RendererType AppStream = new RendererType("AppStream");

        /// <summary>
        /// Constructs a custom RendererType for a value not among the defined constants.
        /// </summary>
        public RendererType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RendererType FindValue(string value)
        {
            return FindValue<RendererType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RendererType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SessionSortBy.
    /// </summary>
    public class SessionSortBy : ConstantClass
    {
        /// <summary>
        /// Constant StartTimeAscending for SessionSortBy
        /// </summary>
        public static readonly SessionSortBy StartTimeAscending = new SessionSortBy("StartTimeAscending");

        /// <summary>
        /// Constant StartTimeDescending for SessionSortBy
        /// </summary>
        public static readonly SessionSortBy StartTimeDescending = new SessionSortBy("StartTimeDescending");

        /// <summary>
        /// Constructs a custom SessionSortBy for a value not among the defined constants.
        /// </summary>
        public SessionSortBy(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionSortBy FindValue(string value)
        {
            return FindValue<SessionSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionSortBy(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type SessionStatus.
    /// </summary>
    public class SessionStatus : ConstantClass
    {
        /// <summary>
        /// Constant Active for SessionStatus
        /// </summary>
        public static readonly SessionStatus Active = new SessionStatus("Active");

        /// <summary>
        /// Constant Terminated for SessionStatus
        /// </summary>
        public static readonly SessionStatus Terminated = new SessionStatus("Terminated");

        /// <summary>
        /// Constructs a custom SessionStatus for a value not among the defined constants.
        /// </summary>
        public SessionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionStatus FindValue(string value)
        {
            return FindValue<SessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ToolbarItem.
    /// </summary>
    public class ToolbarItem : ConstantClass
    {
        /// <summary>
        /// Constant DualMonitor for ToolbarItem
        /// </summary>
        public static readonly ToolbarItem DualMonitor = new ToolbarItem("DualMonitor");

        /// <summary>
        /// Constant FullScreen for ToolbarItem
        /// </summary>
        public static readonly ToolbarItem FullScreen = new ToolbarItem("FullScreen");

        /// <summary>
        /// Constant Microphone for ToolbarItem
        /// </summary>
        public static readonly ToolbarItem Microphone = new ToolbarItem("Microphone");

        /// <summary>
        /// Constant Webcam for ToolbarItem
        /// </summary>
        public static readonly ToolbarItem Webcam = new ToolbarItem("Webcam");

        /// <summary>
        /// Constant Windows for ToolbarItem
        /// </summary>
        public static readonly ToolbarItem Windows = new ToolbarItem("Windows");

        /// <summary>
        /// Constructs a custom ToolbarItem for a value not among the defined constants.
        /// </summary>
        public ToolbarItem(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ToolbarItem FindValue(string value)
        {
            return FindValue<ToolbarItem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ToolbarItem(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ToolbarType.
    /// </summary>
    public class ToolbarType : ConstantClass
    {
        /// <summary>
        /// Constant Docked for ToolbarType
        /// </summary>
        public static readonly ToolbarType Docked = new ToolbarType("Docked");

        /// <summary>
        /// Constant Floating for ToolbarType
        /// </summary>
        public static readonly ToolbarType Floating = new ToolbarType("Floating");

        /// <summary>
        /// Constructs a custom ToolbarType for a value not among the defined constants.
        /// </summary>
        public ToolbarType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ToolbarType FindValue(string value)
        {
            return FindValue<ToolbarType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ToolbarType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {
        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");

        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");

        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");

        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type VisualMode.
    /// </summary>
    public class VisualMode : ConstantClass
    {
        /// <summary>
        /// Constant Dark for VisualMode
        /// </summary>
        public static readonly VisualMode Dark = new VisualMode("Dark");

        /// <summary>
        /// Constant Light for VisualMode
        /// </summary>
        public static readonly VisualMode Light = new VisualMode("Light");

        /// <summary>
        /// Constructs a custom VisualMode for a value not among the defined constants.
        /// </summary>
        public VisualMode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VisualMode FindValue(string value)
        {
            return FindValue<VisualMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VisualMode(string value)
        {
            return FindValue(value);
        }
    }
}
