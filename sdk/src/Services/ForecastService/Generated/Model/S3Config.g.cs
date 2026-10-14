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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The path to the file(s) in an Amazon Simple Storage Service (Amazon S3) bucket, and
    /// an Identity and Access Management (IAM) role that Amazon Forecast can assume to access
    /// the file(s). Optionally, includes an Key Management Service (KMS) key. This object
    /// is part of the <a>DataSource</a> object that is submitted in the <a>CreateDatasetImportJob</a>
    /// request, and part of the <a>DataDestination</a> object.
    /// </summary>
    public partial class S3Config
    {
        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Key Management Service (KMS) key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string KMSKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyArn property is set.
        /// </summary>
        internal bool IsSetKMSKeyArn() => this.KMSKeyArn != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to an Amazon Simple Storage Service (Amazon S3) bucket or file(s) in an Amazon
        /// S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 4096)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Identity and Access Management (IAM) role that Amazon Forecast can
        /// assume to access the Amazon S3 bucket or files. If you provide a value for the <c>KMSKeyArn</c>
        /// key, the role must allow access to the key.
        /// </para>
        ///  
        /// <para>
        /// Passing a role across Amazon Web Services accounts is not allowed. If you pass a role
        /// that isn't in your account, you get an <c>InvalidInputException</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
