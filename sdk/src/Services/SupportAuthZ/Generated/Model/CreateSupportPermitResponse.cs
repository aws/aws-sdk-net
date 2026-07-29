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
 * Do not modify this file. This file is generated from the supportauthz-2026-06-30.normal.json service model.
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
namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// This is the response object from the CreateSupportPermit operation.
    /// </summary>
    public partial class CreateSupportPermitResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private string _name;
        private Permit _permit;
        private SigningKeyInfo _signingKeyInfo;
        private SupportPermitStatus _status;
        private string _supportCaseDisplayId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the permit was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Permit. 
        /// <para>
        /// The permit definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Permit Permit
        {
            get { return this._permit; }
            set { this._permit = value; }
        }

        // Check to see if Permit property is set
        internal bool IsSetPermit()
        {
            return this._permit != null;
        }

        /// <summary>
        /// Gets and sets the property SigningKeyInfo. 
        /// <para>
        /// The signing key information for the permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningKeyInfo SigningKeyInfo
        {
            get { return this._signingKeyInfo; }
            set { this._signingKeyInfo = value; }
        }

        // Check to see if SigningKeyInfo property is set
        internal bool IsSetSigningKeyInfo()
        {
            return this._signingKeyInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportPermitStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCaseDisplayId. 
        /// <para>
        /// The display identifier of the support case associated with the permit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SupportCaseDisplayId
        {
            get { return this._supportCaseDisplayId; }
            set { this._supportCaseDisplayId = value; }
        }

        // Check to see if SupportCaseDisplayId property is set
        internal bool IsSetSupportCaseDisplayId()
        {
            return this._supportCaseDisplayId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the support permit.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}