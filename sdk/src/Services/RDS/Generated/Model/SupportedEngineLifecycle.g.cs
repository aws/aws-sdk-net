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
    /// This data type is used as a response element in the operation <c>DescribeDBMajorEngineVersions</c>.
    /// 
    ///  
    /// <para>
    /// You can use the information that this data type returns to plan for upgrades.
    /// </para>
    ///  
    /// <para>
    /// This data type only returns information for the open source engines Amazon RDS for
    /// MariaDB, Amazon RDS for MySQL, Amazon RDS for PostgreSQL, Aurora MySQL, and Aurora
    /// PostgreSQL.
    /// </para>
    /// </summary>
    public partial class SupportedEngineLifecycle
    {
        /// <summary>
        /// Gets and sets the property LifecycleSupportEndDate. 
        /// <para>
        /// The end date for the type of support returned by <c>LifecycleSupportName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LifecycleSupportEndDate { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleSupportEndDate property is set.
        /// </summary>
        internal bool IsSetLifecycleSupportEndDate() => this.LifecycleSupportEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleSupportName. 
        /// <para>
        /// The type of lifecycle support that the engine version is in.
        /// </para>
        ///  
        /// <para>
        /// This parameter returns the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>open-source-rds-standard-support</c> - Indicates RDS standard support or Aurora
        /// standard support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>open-source-rds-extended-support</c> - Indicates Amazon RDS Extended Support.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For Amazon RDS for MySQL, Amazon RDS for PostgreSQL, Aurora MySQL, and Aurora PostgreSQL,
        /// this parameter returns both <c>open-source-rds-standard-support</c> and <c>open-source-rds-extended-support</c>.
        /// </para>
        ///  
        /// <para>
        /// For Amazon RDS for MariaDB, this parameter only returns the value <c>open-source-rds-standard-support</c>.
        /// </para>
        ///  
        /// <para>
        /// For information about Amazon RDS Extended Support, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon RDS</a> in the <i>Amazon RDS User Guide</i> and <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon Aurora</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LifecycleSupportName LifecycleSupportName { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleSupportName property is set.
        /// </summary>
        internal bool IsSetLifecycleSupportName() => this.LifecycleSupportName != null;

        /// <summary>
        /// Gets and sets the property LifecycleSupportStartDate. 
        /// <para>
        /// The start date for the type of support returned by <c>LifecycleSupportName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LifecycleSupportStartDate { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleSupportStartDate property is set.
        /// </summary>
        internal bool IsSetLifecycleSupportStartDate() => this.LifecycleSupportStartDate.HasValue;
    }
}
