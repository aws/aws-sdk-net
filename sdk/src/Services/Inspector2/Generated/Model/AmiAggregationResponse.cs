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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of a finding aggregation by AMI.
    /// </summary>
    public partial class AmiAggregationResponse
    {
        private string _accountId;
        private long? _affectedInstances;
        private string _ami;
        private string _cloudAccountId;
        private string _cloudOrgId;
        private string _cloudPartition;
        private Provider _cloudProvider;
        private string _cloudRegion;
        private SeverityCounts _severityCounts;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AffectedInstances. 
        /// <para>
        /// The IDs of Amazon EC2 instances using this AMI.
        /// </para>
        /// </summary>
        public long? AffectedInstances
        {
            get { return this._affectedInstances; }
            set { this._affectedInstances = value; }
        }

        // Check to see if AffectedInstances property is set
        internal bool IsSetAffectedInstances()
        {
            return this._affectedInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ami. 
        /// <para>
        /// The ID of the AMI that findings were aggregated for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Ami
        {
            get { return this._ami; }
            set { this._ami = value; }
        }

        // Check to see if Ami property is set
        internal bool IsSetAmi()
        {
            return this._ami != null;
        }

        /// <summary>
        /// Gets and sets the property CloudAccountId. 
        /// <para>
        /// The cloud account ID for the AMI aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string CloudAccountId
        {
            get { return this._cloudAccountId; }
            set { this._cloudAccountId = value; }
        }

        // Check to see if CloudAccountId property is set
        internal bool IsSetCloudAccountId()
        {
            return this._cloudAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudOrgId. 
        /// <para>
        /// The cloud organization ID for the AMI aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string CloudOrgId
        {
            get { return this._cloudOrgId; }
            set { this._cloudOrgId = value; }
        }

        // Check to see if CloudOrgId property is set
        internal bool IsSetCloudOrgId()
        {
            return this._cloudOrgId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudPartition. 
        /// <para>
        /// The cloud infrastructure partition associated with this AMI aggregation. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> – Amazon Web Services commercial Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> – Amazon Web Services China Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> – Amazon Web Services GovCloud (US) Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AzureCloud</c> – Azure commercial Regions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CloudPartition
        {
            get { return this._cloudPartition; }
            set { this._cloudPartition = value; }
        }

        // Check to see if CloudPartition property is set
        internal bool IsSetCloudPartition()
        {
            return this._cloudPartition != null;
        }

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud service provider associated with this Amazon Machine Image (AMI) aggregation.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c> – Findings from Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AZURE</c> – Findings from Microsoft Azure resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Provider CloudProvider
        {
            get { return this._cloudProvider; }
            set { this._cloudProvider = value; }
        }

        // Check to see if CloudProvider property is set
        internal bool IsSetCloudProvider()
        {
            return this._cloudProvider != null;
        }

        /// <summary>
        /// Gets and sets the property CloudRegion. 
        /// <para>
        /// The cloud Region associated with this AMI aggregation. The value format depends on
        /// the cloud provider:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services Region, such as <c>us-east-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Azure region, such as <c>eastus</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CloudRegion
        {
            get { return this._cloudRegion; }
            set { this._cloudRegion = value; }
        }

        // Check to see if CloudRegion property is set
        internal bool IsSetCloudRegion()
        {
            return this._cloudRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// An object that contains the count of matched findings per severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts
        {
            get { return this._severityCounts; }
            set { this._severityCounts = value; }
        }

        // Check to see if SeverityCounts property is set
        internal bool IsSetSeverityCounts()
        {
            return this._severityCounts != null;
        }

    }
}