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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnabledType(string value)
            : base(value)
        {
        }

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
        /// Constant UrlLoad for Event
        /// </summary>
        public static readonly Event UrlLoad = new Event("UrlLoad");
        /// <summary>
        /// Constant WebsiteInteract for Event
        /// </summary>
        public static readonly Event WebsiteInteract = new Event("WebsiteInteract");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Event(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FolderStructure(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityProviderType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceType(string value)
            : base(value)
        {
        }

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
    /// Constants used for properties of type LogFileFormat.
    /// </summary>
    public class LogFileFormat : ConstantClass
    {

        /// <summary>
        /// Constant Json for LogFileFormat
        /// </summary>
        public static readonly LogFileFormat Json = new LogFileFormat("Json");
        /// <summary>
        /// Constant JSONLines for LogFileFormat
        /// </summary>
        public static readonly LogFileFormat JSONLines = new LogFileFormat("JSONLines");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogFileFormat(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaxDisplayResolution(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortalStatus(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedactionPlaceHolderType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RendererType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionSortBy(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionStatus(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ToolbarItem(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ToolbarType(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

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
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VisualMode(string value)
            : base(value)
        {
        }

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