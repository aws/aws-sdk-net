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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Describes a resource share.
    /// </summary>
    public partial class ResourceShare
    {
        private bool? _allowExternalPrincipals;
        private DateTime? _creationTime;
        private ResourceShareFeatureSet _featureSet;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _owningAccountId;
        private string _resourceShareArn;
        private ResourceShareStatus _status;
        private string _statusMessage;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AllowExternalPrincipals. 
        /// <para>
        /// Indicates whether principals outside your AWS organization can be associated with
        /// a resource share.
        /// </para>
        /// </summary>
        public bool AllowExternalPrincipals
        {
            get { return this._allowExternalPrincipals.GetValueOrDefault(); }
            set { this._allowExternalPrincipals = value; }
        }

        // Check to see if AllowExternalPrincipals property is set
        internal bool IsSetAllowExternalPrincipals()
        {
            return this._allowExternalPrincipals.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the resource share was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeatureSet. 
        /// <para>
        /// Indicates how the resource share was created. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATED_FROM_POLICY</code> - Indicates that the resource share was created
        /// from an AWS Identity and Access Management (AWS IAM) policy attached to a resource.
        /// These resource shares are visible only to the AWS account that created it. They cannot
        /// be modified in AWS RAM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PROMOTING_TO_STANDARD</code> - The resource share is in the process of being
        /// promoted. For more information, see <a>PromoteResourceShareCreatedFromPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STANDARD</code> - Indicates that the resource share was created in AWS RAM
        /// using the console or APIs. These resource shares are visible to all principals. They
        /// can be modified in AWS RAM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceShareFeatureSet FeatureSet
        {
            get { return this._featureSet; }
            set { this._featureSet = value; }
        }

        // Check to see if FeatureSet property is set
        internal bool IsSetFeatureSet()
        {
            return this._featureSet != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the resource share was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource share.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwningAccountId. 
        /// <para>
        /// The ID of the AWS account that owns the resource share.
        /// </para>
        /// </summary>
        public string OwningAccountId
        {
            get { return this._owningAccountId; }
            set { this._owningAccountId = value; }
        }

        // Check to see if OwningAccountId property is set
        internal bool IsSetOwningAccountId()
        {
            return this._owningAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource share.
        /// </para>
        /// </summary>
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the resource share.
        /// </para>
        /// </summary>
        public ResourceShareStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message about the status of the resource share.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the resource share.
        /// </para>
        /// </summary>
        public List<Tag> Tags
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