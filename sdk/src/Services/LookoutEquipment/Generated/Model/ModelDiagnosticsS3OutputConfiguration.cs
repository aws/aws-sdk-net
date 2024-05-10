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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// The Amazon S3 location for the pointwise model diagnostics for an Amazon Lookout for
    /// Equipment model.
    /// </summary>
    public partial class ModelDiagnosticsS3OutputConfiguration
    {
        private string _bucket;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where the pointwise model diagnostics are located.
        /// You must be the owner of the Amazon S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The Amazon S3 prefix for the location of the pointwise model diagnostics. The prefix
        /// specifies the folder and evaluation result file name. (<c>bucket</c>).
        /// </para>
        ///  
        /// <para>
        /// When you call <c>CreateModel</c> or <c>UpdateModel</c>, specify the path within the
        /// bucket that you want Lookout for Equipment to save the model to. During training,
        /// Lookout for Equipment creates the model evaluation model as a compressed JSON file
        /// with the name <c>model_diagnostics_results.json.gz</c>.
        /// </para>
        ///  
        /// <para>
        /// When you call <c>DescribeModel</c> or <c>DescribeModelVersion</c>, <c>prefix</c> contains
        /// the file path and filename of the model evaluation file. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}