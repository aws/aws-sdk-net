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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
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
namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Output Mixin
    /// </summary>
    public partial class UpdateClusterResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private bool? _deletionProtectionEnabled;
        private string _identifier;
        private List<string> _linkedClusterArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ClusterStatus _status;
        private string _witnessRegion;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the updated cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time of when the cluster was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Whether deletion protection is enabled for the updated cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled.GetValueOrDefault(); }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property LinkedClusterArns. 
        /// <para>
        /// The ARNs of the clusters linked to the updated cluster. Applicable only for multi-Region
        /// clusters.
        /// </para>
        /// </summary>
        public List<string> LinkedClusterArns
        {
            get { return this._linkedClusterArns; }
            set { this._linkedClusterArns = value; }
        }

        // Check to see if LinkedClusterArns property is set
        internal bool IsSetLinkedClusterArns()
        {
            return this._linkedClusterArns != null && (this._linkedClusterArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the updated cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterStatus Status
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
        /// Gets and sets the property WitnessRegion. 
        /// <para>
        /// The Region that receives all data you write to linked clusters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public string WitnessRegion
        {
            get { return this._witnessRegion; }
            set { this._witnessRegion = value; }
        }

        // Check to see if WitnessRegion property is set
        internal bool IsSetWitnessRegion()
        {
            return this._witnessRegion != null;
        }

    }
}