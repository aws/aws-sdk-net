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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the processor features of a DB instance class.
    /// 
    ///  
    /// <para>
    /// To specify the number of CPU cores, use the <code>coreCount</code> feature name for
    /// the <code>Name</code> parameter. To specify the number of threads per core, use the
    /// <code>threadsPerCore</code> feature name for the <code>Name</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// You can set the processor features of the DB instance class for a DB instance when
    /// you call one of the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CreateDBInstance</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ModifyDBInstance</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RestoreDBInstanceFromDBSnapshot</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RestoreDBInstanceFromS3</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RestoreDBInstanceToPointInTime</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can view the valid processor values for a particular instance class by calling
    /// the <code>DescribeOrderableDBInstanceOptions</code> action and specifying the instance
    /// class for the <code>DBInstanceClass</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// In addition, you can use the following actions for DB instance class processor information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>DescribeDBInstances</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeDBSnapshots</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeValidDBInstanceModifications</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you call <code>DescribeDBInstances</code>, <code>ProcessorFeature</code> returns
    /// non-null values only if the following conditions are met:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You are accessing an Oracle DB instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your Oracle DB instance class supports configuring the number of CPU cores and threads
    /// per core.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The current number CPU cores and threads is set to a non-default value.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html#USER_ConfigureProcessor">Configuring
    /// the Processor of the DB Instance Class</a> in the <i>Amazon RDS User Guide. </i> 
    /// </para>
    /// </summary>
    public partial class ProcessorFeature
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the processor feature. Valid names are <code>coreCount</code> and <code>threadsPerCore</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of a processor feature name.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}