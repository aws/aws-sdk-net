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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the StartThingRegistrationTask operation.
    /// Creates a bulk thing provisioning task.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartThingRegistrationTask</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class StartThingRegistrationTaskRequest : AmazonIoTRequest
    {
        private string _inputFileBucket;
        private string _inputFileKey;
        private string _roleArn;
        private string _templateBody;

        /// <summary>
        /// Gets and sets the property InputFileBucket. 
        /// <para>
        /// The S3 bucket that contains the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
        public string InputFileBucket
        {
            get { return this._inputFileBucket; }
            set { this._inputFileBucket = value; }
        }

        // Check to see if InputFileBucket property is set
        internal bool IsSetInputFileBucket()
        {
            return this._inputFileBucket != null;
        }

        /// <summary>
        /// Gets and sets the property InputFileKey. 
        /// <para>
        /// The name of input file within the S3 bucket. This file contains a newline delimited
        /// JSON file. Each line contains the parameter values to provision one device (thing).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string InputFileKey
        {
            get { return this._inputFileKey; }
            set { this._inputFileKey = value; }
        }

        // Check to see if InputFileKey property is set
        internal bool IsSetInputFileKey()
        {
            return this._inputFileKey != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN that grants permission the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10240)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

    }
}