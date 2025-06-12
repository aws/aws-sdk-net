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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// This is the response object from the UpdateExtensionAssociation operation.
    /// </summary>
    public partial class UpdateExtensionAssociationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _extensionArn;
        private int? _extensionVersionNumber;
        private string _id;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The system-generated Amazon Resource Name (ARN) for the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ExtensionArn. 
        /// <para>
        /// The ARN of the extension defined in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExtensionArn
        {
            get { return this._extensionArn; }
            set { this._extensionArn = value; }
        }

        // Check to see if ExtensionArn property is set
        internal bool IsSetExtensionArn()
        {
            return this._extensionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExtensionVersionNumber. 
        /// <para>
        /// The version number for the extension defined in the association.
        /// </para>
        /// </summary>
        public int? ExtensionVersionNumber
        {
            get { return this._extensionVersionNumber; }
            set { this._extensionVersionNumber = value; }
        }

        // Check to see if ExtensionVersionNumber property is set
        internal bool IsSetExtensionVersionNumber()
        {
            return this._extensionVersionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The system-generated ID for the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter names and values defined in the association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARNs of applications, configuration profiles, or environments defined in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}