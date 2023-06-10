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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the GetInstanceTypesFromInstanceRequirements operation.
    /// Returns a list of instance types with the specified instance attributes. You can use
    /// the response to preview the instance types without launching instances. Note that
    /// the response does not consider capacity.
    /// 
    ///  
    /// <para>
    /// When you specify multiple parameters, you get instance types that satisfy all of the
    /// specified parameters. If you specify multiple values for a parameter, you get instance
    /// types that satisfy any of the specified values.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-attribute-based-instance-type-selection.html#spotfleet-get-instance-types-from-instance-requirements">Preview
    /// instance types with specified attributes</a>, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html">Attribute-based
    /// instance type selection for EC2 Fleet</a>, <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-attribute-based-instance-type-selection.html">Attribute-based
    /// instance type selection for Spot Fleet</a>, and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html">Spot
    /// placement score</a> in the <i>Amazon EC2 User Guide</i>, and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-asg-instance-type-requirements.html">Creating
    /// an Auto Scaling group using attribute-based instance type selection</a> in the <i>Amazon
    /// EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetInstanceTypesFromInstanceRequirementsRequest : AmazonEC2Request
    {
        private List<string> _architectureTypes = new List<string>();
        private InstanceRequirementsRequest _instanceRequirements;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _virtualizationTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property ArchitectureTypes. 
        /// <para>
        /// The processor architecture type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3)]
        public List<string> ArchitectureTypes
        {
            get { return this._architectureTypes; }
            set { this._architectureTypes = value; }
        }

        // Check to see if ArchitectureTypes property is set
        internal bool IsSetArchitectureTypes()
        {
            return this._architectureTypes != null && this._architectureTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The attributes required for the instance types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceRequirementsRequest InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualizationTypes. 
        /// <para>
        /// The virtualization type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2)]
        public List<string> VirtualizationTypes
        {
            get { return this._virtualizationTypes; }
            set { this._virtualizationTypes = value; }
        }

        // Check to see if VirtualizationTypes property is set
        internal bool IsSetVirtualizationTypes()
        {
            return this._virtualizationTypes != null && this._virtualizationTypes.Count > 0; 
        }

    }
}