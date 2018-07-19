/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    ///  <a>CreateDBInstance</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ModifyDBInstance</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RestoreDBInstanceFromDBSnapshot</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RestoreDBInstanceFromS3</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RestoreDBInstanceToPointInTime</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can view the valid processor values for a particular instance class by calling
    /// the <a>DescribeOrderableDBInstanceOptions</a> action and specifying the instance class
    /// for the <code>DBInstanceClass</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// In addition, you can use the following actions for DB instance class processor information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeDBInstances</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeDBSnapshots</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeValidDBInstanceModifications</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html#USER_ConfigureProcessor">Configuring
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