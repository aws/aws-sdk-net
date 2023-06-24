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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateExtensionAssociation operation.
    /// When you create an extension or configure an Amazon Web Services authored extension,
    /// you associate the extension with an AppConfig application, environment, or configuration
    /// profile. For example, you can choose to run the <code>AppConfig deployment events
    /// to Amazon SNS</code> Amazon Web Services authored extension and receive notifications
    /// on an Amazon SNS topic anytime a configuration deployment is started for a specific
    /// application. Defining which extension to associate with an AppConfig resource is called
    /// an <i>extension association</i>. An extension association is a specified relationship
    /// between an extension and an AppConfig resource, such as an application or a configuration
    /// profile. For more information about extensions and associations, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Working
    /// with AppConfig extensions</a> in the <i>AppConfig User Guide</i>.
    /// </summary>
    public partial class CreateExtensionAssociationRequest : AmazonAppConfigRequest
    {
        private string _extensionIdentifier;
        private int? _extensionVersionNumber;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _resourceIdentifier;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ExtensionIdentifier. 
        /// <para>
        /// The name, the ID, or the Amazon Resource Name (ARN) of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ExtensionIdentifier
        {
            get { return this._extensionIdentifier; }
            set { this._extensionIdentifier = value; }
        }

        // Check to see if ExtensionIdentifier property is set
        internal bool IsSetExtensionIdentifier()
        {
            return this._extensionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ExtensionVersionNumber. 
        /// <para>
        /// The version number of the extension. If not specified, AppConfig uses the maximum
        /// version of the extension.
        /// </para>
        /// </summary>
        public int ExtensionVersionNumber
        {
            get { return this._extensionVersionNumber.GetValueOrDefault(); }
            set { this._extensionVersionNumber = value; }
        }

        // Check to see if ExtensionVersionNumber property is set
        internal bool IsSetExtensionVersionNumber()
        {
            return this._extensionVersionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter names and values defined in the extensions. Extension parameters marked
        /// <code>Required</code> must be entered for this field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The ARN of an application, configuration profile, or environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds one or more tags for the specified extension association. Tags are metadata that
        /// help you categorize resources in different ways, for example, by purpose, owner, or
        /// environment. Each tag consists of a key and an optional value, both of which you define.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}