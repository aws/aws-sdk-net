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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The driver that the job runs on.
    /// </summary>
    public partial class JobDriver
    {
        private Hive _hive;
        private SparkSubmit _sparkSubmit;

        /// <summary>
        /// Gets and sets the property Hive. 
        /// <para>
        /// The job driver parameters specified for Hive.
        /// </para>
        /// </summary>
        public Hive Hive
        {
            get { return this._hive; }
            set { this._hive = value; }
        }

        // Check to see if Hive property is set
        internal bool IsSetHive()
        {
            return this._hive != null;
        }

        /// <summary>
        /// Gets and sets the property SparkSubmit. 
        /// <para>
        /// The job driver parameters specified for Spark.
        /// </para>
        /// </summary>
        public SparkSubmit SparkSubmit
        {
            get { return this._sparkSubmit; }
            set { this._sparkSubmit = value; }
        }

        // Check to see if SparkSubmit property is set
        internal bool IsSetSparkSubmit()
        {
            return this._sparkSubmit != null;
        }

    }
}