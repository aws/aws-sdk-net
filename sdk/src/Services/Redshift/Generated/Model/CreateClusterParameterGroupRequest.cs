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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateClusterParameterGroup operation.
    /// Creates an Amazon Redshift parameter group.
    /// 
    ///  
    /// <para>
    /// Creating parameter groups is independent of creating clusters. You can associate a
    /// cluster with a parameter group when you create the cluster. You can also associate
    /// an existing cluster with a parameter group after the cluster is created by using <a>ModifyCluster</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Parameters in the parameter group define specific behavior that applies to the databases
    /// you create on the cluster. For more information about parameters and parameter groups,
    /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
    /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateClusterParameterGroupRequest : AmazonRedshiftRequest
    {
        private string _description;
        private string _parameterGroupFamily;
        private string _parameterGroupName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// Gets and sets the property ParameterGroupFamily. 
        /// <para>
        /// The Amazon Redshift engine version to which the cluster parameter group applies. The
        /// cluster engine version determines the set of parameters.
        /// </para>
        ///  
        /// <para>
        /// To get a list of valid parameter group family names, you can call <a>DescribeClusterParameterGroups</a>.
        /// By default, Amazon Redshift returns a list of all the parameter groups that are owned
        /// by your Amazon Web Services account, including the default parameter groups for each
        /// Amazon Redshift engine version. The parameter group family names associated with the
        /// default parameter groups provide you the valid values. For example, a valid family
        /// name is "redshift-1.0". 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ParameterGroupFamily
        {
            get { return this._parameterGroupFamily; }
            set { this._parameterGroupFamily = value; }
        }

        // Check to see if ParameterGroupFamily property is set
        internal bool IsSetParameterGroupFamily()
        {
            return this._parameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the cluster parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 alphanumeric characters or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be unique withing your Amazon Web Services account.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This value is stored as a lower-case string.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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