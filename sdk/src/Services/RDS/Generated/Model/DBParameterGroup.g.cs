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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the details of an Amazon RDS DB parameter group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBParameterGroups</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBParameterGroup
    {
        /// <summary>
        /// Gets and sets the property DBParameterGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB parameter group.
        /// </para>
        /// </summary>
        public string DBParameterGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DBParameterGroupArn property is set.
        /// </summary>
        internal bool IsSetDBParameterGroupArn() => this.DBParameterGroupArn != null;

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The name of the DB parameter group family that this DB parameter group is compatible
        /// with.
        /// </para>
        /// </summary>
        public string DBParameterGroupFamily { get; set; }

        /// <summary>
        /// Checks to see if the DBParameterGroupFamily property is set.
        /// </summary>
        internal bool IsSetDBParameterGroupFamily() => this.DBParameterGroupFamily != null;

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group.
        /// </para>
        /// </summary>
        public string DBParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBParameterGroupName property is set.
        /// </summary>
        internal bool IsSetDBParameterGroupName() => this.DBParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Provides the customer-specified description for this DB parameter group.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
