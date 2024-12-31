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
    /// Summary information about a service network.
    /// </summary>
    public partial class ServiceNetworkSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private long? _numberOfAssociatedResourceConfigurations;
        private long? _numberOfAssociatedServices;
        private long? _numberOfAssociatedVPCs;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=2048)]
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
        /// The date and time that the service network was created, in ISO-8601 format.
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
        /// The ID of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
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
        /// The date and time that the service network was last updated, in ISO-8601 format.
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
        /// The name of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// Gets and sets the property NumberOfAssociatedResourceConfigurations. 
        /// <para>
        /// The number of resource configurations associated with a service network.
        /// </para>
        /// </summary>
        public long? NumberOfAssociatedResourceConfigurations
        {
            get { return this._numberOfAssociatedResourceConfigurations; }
            set { this._numberOfAssociatedResourceConfigurations = value; }
        }

        // Check to see if NumberOfAssociatedResourceConfigurations property is set
        internal bool IsSetNumberOfAssociatedResourceConfigurations()
        {
            return this._numberOfAssociatedResourceConfigurations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAssociatedServices. 
        /// <para>
        /// The number of services associated with the service network.
        /// </para>
        /// </summary>
        public long? NumberOfAssociatedServices
        {
            get { return this._numberOfAssociatedServices; }
            set { this._numberOfAssociatedServices = value; }
        }

        // Check to see if NumberOfAssociatedServices property is set
        internal bool IsSetNumberOfAssociatedServices()
        {
            return this._numberOfAssociatedServices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfAssociatedVPCs. 
        /// <para>
        /// The number of VPCs associated with the service network.
        /// </para>
        /// </summary>
        public long? NumberOfAssociatedVPCs
        {
            get { return this._numberOfAssociatedVPCs; }
            set { this._numberOfAssociatedVPCs = value; }
        }

        // Check to see if NumberOfAssociatedVPCs property is set
        internal bool IsSetNumberOfAssociatedVPCs()
        {
            return this._numberOfAssociatedVPCs.HasValue; 
        }

    }
}