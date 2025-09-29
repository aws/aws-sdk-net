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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Summary information about a resource configuration.
    /// </summary>
    public partial class ResourceConfigurationSummary
    {
        private bool? _amazonManaged;
        private string _arn;
        private DateTime? _createdAt;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private string _resourceConfigurationGroupId;
        private string _resourceGatewayId;
        private ResourceConfigurationStatus _status;
        private ResourceConfigurationType _type;

        /// <summary>
        /// Gets and sets the property AmazonManaged. 
        /// <para>
        /// Indicates whether the resource configuration was created and is managed by Amazon.
        /// </para>
        /// </summary>
        public bool? AmazonManaged
        {
            get { return this._amazonManaged; }
            set { this._amazonManaged = value; }
        }

        // Check to see if AmazonManaged property is set
        internal bool IsSetAmazonManaged()
        {
            return this._amazonManaged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the resource configuration was created, in ISO-8601 format.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The most recent date and time that the resource configuration was updated, in ISO-8601
        /// format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=40)]
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
        /// Gets and sets the property ResourceConfigurationGroupId. 
        /// <para>
        /// The ID of the group resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string ResourceConfigurationGroupId
        {
            get { return this._resourceConfigurationGroupId; }
            set { this._resourceConfigurationGroupId = value; }
        }

        // Check to see if ResourceConfigurationGroupId property is set
        internal bool IsSetResourceConfigurationGroupId()
        {
            return this._resourceConfigurationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGatewayId. 
        /// <para>
        /// The ID of the resource gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string ResourceGatewayId
        {
            get { return this._resourceGatewayId; }
            set { this._resourceGatewayId = value; }
        }

        // Check to see if ResourceGatewayId property is set
        internal bool IsSetResourceGatewayId()
        {
            return this._resourceGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the resource configuration.
        /// </para>
        /// </summary>
        public ResourceConfigurationStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SINGLE</c> - A single resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GROUP</c> - A group of resources. You must create a group resource configuration
        /// before you create a child resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHILD</c> - A single resource that is part of a group resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARN</c> - An Amazon Web Services resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceConfigurationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}