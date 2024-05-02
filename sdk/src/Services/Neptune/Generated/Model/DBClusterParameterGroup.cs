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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains the details of an Amazon Neptune DB cluster parameter group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>DescribeDBClusterParameterGroups</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBClusterParameterGroup
    {
        private string _dbClusterParameterGroupArn;
        private string _dbClusterParameterGroupName;
        private string _dbParameterGroupFamily;
        private string _description;

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB cluster parameter group.
        /// </para>
        /// </summary>
        public string DBClusterParameterGroupArn
        {
            get { return this._dbClusterParameterGroupArn; }
            set { this._dbClusterParameterGroupArn = value; }
        }

        // Check to see if DBClusterParameterGroupArn property is set
        internal bool IsSetDBClusterParameterGroupArn()
        {
            return this._dbClusterParameterGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// Provides the name of the DB cluster parameter group.
        /// </para>
        /// </summary>
        public string DBClusterParameterGroupName
        {
            get { return this._dbClusterParameterGroupName; }
            set { this._dbClusterParameterGroupName = value; }
        }

        // Check to see if DBClusterParameterGroupName property is set
        internal bool IsSetDBClusterParameterGroupName()
        {
            return this._dbClusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// Provides the name of the DB parameter group family that this DB cluster parameter
        /// group is compatible with.
        /// </para>
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this._dbParameterGroupFamily; }
            set { this._dbParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this._dbParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Provides the customer-specified description for this DB cluster parameter group.
        /// </para>
        /// </summary>
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

    }
}