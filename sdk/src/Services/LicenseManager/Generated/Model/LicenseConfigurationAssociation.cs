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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes an association with a license configuration.
    /// </summary>
    public partial class LicenseConfigurationAssociation
    {
        private string _amiAssociationScope;
        private DateTime? _associationTime;
        private string _resourceArn;
        private string _resourceOwnerId;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property AmiAssociationScope. 
        /// <para>
        /// Scope of AMI associations. The possible value is <c>cross-account</c>.
        /// </para>
        /// </summary>
        public string AmiAssociationScope
        {
            get { return this._amiAssociationScope; }
            set { this._amiAssociationScope = value; }
        }

        // Check to see if AmiAssociationScope property is set
        internal bool IsSetAmiAssociationScope()
        {
            return this._amiAssociationScope != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationTime. 
        /// <para>
        /// Time when the license configuration was associated with the resource.
        /// </para>
        /// </summary>
        public DateTime? AssociationTime
        {
            get { return this._associationTime; }
            set { this._associationTime = value; }
        }

        // Check to see if AssociationTime property is set
        internal bool IsSetAssociationTime()
        {
            return this._associationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// ID of the Amazon Web Services account that owns the resource consuming licenses.
        /// </para>
        /// </summary>
        public string ResourceOwnerId
        {
            get { return this._resourceOwnerId; }
            set { this._resourceOwnerId = value; }
        }

        // Check to see if ResourceOwnerId property is set
        internal bool IsSetResourceOwnerId()
        {
            return this._resourceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of server resource.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}