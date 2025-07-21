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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Use this structure to input your script code for the canary. This structure contains
    /// the Lambda handler with the location where the canary should start running the script.
    /// If the script is stored in an Amazon S3 bucket, the bucket name, key, and version
    /// are also included. If the script was passed into the canary directly, the script code
    /// is contained in the value of <c>Zipfile</c>. 
    /// 
    ///  
    /// <para>
    /// If you are uploading your canary scripts with an Amazon S3 bucket, your zip file should
    /// include your script in a certain folder structure.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For Node.js canaries, the folder structure must be <c>nodejs/node_modules/<i>myCanaryFilename.js</i>
    /// </c> For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_WritingCanary_Nodejs.html#CloudWatch_Synthetics_Canaries_package">Packaging
    /// your Node.js canary files</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For Python canaries, the folder structure must be <c>python/<i>myCanaryFilename.py</i>
    /// </c> or <c>python/<i>myFolder/myCanaryFilename.py</i> </c> For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_WritingCanary_Python.html#CloudWatch_Synthetics_Canaries_WritingCanary_Python_package">Packaging
    /// your Python canary files</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CanaryCodeInput
    {
        private List<Dependency> _dependencies = AWSConfigs.InitializeCollections ? new List<Dependency>() : null;
        private string _handler;
        private string _s3Bucket;
        private string _s3Key;
        private string _s3Version;
        private MemoryStream _zipFile;

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// A list of dependencies that should be used for running this canary. Specify the dependencies
        /// as a key-value pair, where the key is the type of dependency and the value is the
        /// dependency reference.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Dependency> Dependencies
        {
            get { return this._dependencies; }
            set { this._dependencies = value; }
        }

        // Check to see if Dependencies property is set
        internal bool IsSetDependencies()
        {
            return this._dependencies != null && (this._dependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Handler. 
        /// <para>
        /// The entry point to use for the source code when running the canary. For canaries that
        /// use the <c>syn-python-selenium-1.0</c> runtime or a <c>syn-nodejs.puppeteer</c> runtime
        /// earlier than <c>syn-nodejs.puppeteer-3.4</c>, the handler must be specified as <c>
        /// <i>fileName</i>.handler</c>. For <c>syn-python-selenium-1.1</c>, <c>syn-nodejs.puppeteer-3.4</c>,
        /// and later runtimes, the handler can be specified as <c> <i>fileName</i>.<i>functionName</i>
        /// </c>, or you can specify a folder where canary scripts reside as <c> <i>folder</i>/<i>fileName</i>.<i>functionName</i>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Handler
        {
            get { return this._handler; }
            set { this._handler = value; }
        }

        // Check to see if Handler property is set
        internal bool IsSetHandler()
        {
            return this._handler != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// If your canary script is located in Amazon S3, specify the bucket name here. Do not
        /// include <c>s3://</c> as the start of the bucket name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The Amazon S3 key of your script. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingObjects.html">Working
        /// with Amazon S3 Objects</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3Key
        {
            get { return this._s3Key; }
            set { this._s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this._s3Key != null;
        }

        /// <summary>
        /// Gets and sets the property S3Version. 
        /// <para>
        /// The Amazon S3 version ID of your script.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3Version
        {
            get { return this._s3Version; }
            set { this._s3Version = value; }
        }

        // Check to see if S3Version property is set
        internal bool IsSetS3Version()
        {
            return this._s3Version != null;
        }

        /// <summary>
        /// Gets and sets the property ZipFile. 
        /// <para>
        /// If you input your canary script directly into the canary instead of referring to an
        /// Amazon S3 location, the value of this parameter is the base64-encoded contents of
        /// the .zip file that contains the script. It must be smaller than 225 Kb.
        /// </para>
        ///  
        /// <para>
        /// For large canary scripts, we recommend that you use an Amazon S3 location instead
        /// of inputting it directly with this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000000)]
        public MemoryStream ZipFile
        {
            get { return this._zipFile; }
            set { this._zipFile = value; }
        }

        // Check to see if ZipFile property is set
        internal bool IsSetZipFile()
        {
            return this._zipFile != null;
        }

    }
}