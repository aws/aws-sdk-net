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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the StartThingRegistrationTask operation. Creates
    /// a bulk thing provisioning task. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartThingRegistrationTask</a>
    /// action. </para>
    /// </summary>
    public partial class StartThingRegistrationTaskRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property InputFileBucket. 
        /// <para>
        /// The S3 bucket that contains the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 256)]
        public string InputFileBucket { get; set; }

        /// <summary>
        /// Checks to see if the InputFileBucket property is set.
        /// </summary>
        internal bool IsSetInputFileBucket() => this.InputFileBucket != null;

        /// <summary>
        /// Gets and sets the property InputFileKey. 
        /// <para>
        /// The name of input file within the S3 bucket. This file contains a newline delimited
        /// JSON file. Each line contains the parameter values to provision one device (thing).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string InputFileKey { get; set; }

        /// <summary>
        /// Checks to see if the InputFileKey property is set.
        /// </summary>
        internal bool IsSetInputFileKey() => this.InputFileKey != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN that grants permission the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The provisioning template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10240)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the TemplateBody property is set.
        /// </summary>
        internal bool IsSetTemplateBody() => this.TemplateBody != null;
    }
}
