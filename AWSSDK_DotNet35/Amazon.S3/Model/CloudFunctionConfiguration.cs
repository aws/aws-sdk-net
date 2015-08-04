/*
 * Copyright 2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This class contains the configuration Amazon S3 uses to figure out what events you want to listen 
    /// and send the event to an Amazon Lambda cloud function.
    /// </summary>
    [Obsolete("CloudFunctionConfiguration is obsolete and will be removed in the upcoming version 3 of the SDK. " +
        "LambdaFunctionConfiguration should be used instead, along with using IAmazonLambda.AddPermission for setting up permissions.")]
    public class CloudFunctionConfiguration : NotificationConfiguration
    {
        /// <summary>
        /// Gets and set the Id property. The Id will be provided in the event content and can be used 
        /// to identify which configuration caused an event to fire. If the Id is not provided for the configuration, one will be generated.
        /// </summary>
        public string Id { get; set; }

        internal bool IsSetId()
        {
            return this.Id != null;
        }


        /// <summary>
        /// Gets and sets the CloudFormation property. This is the Amazon Lambda cloud function to which Amazon S3 will invoke with the events.
        /// </summary>
        public string CloudFunction { get; set; }

        // Check to see if Queue property is set
        internal bool IsSetCloudFunction()
        {
            return this.CloudFunction != null;
        }

        /// <summary>
        /// Gets and sets the InvocationRole property. The InvocationRole is an Identity and Access Management role that is used
        /// invoke the CloudFunction.
        /// </summary>
        public string InvocationRole { get; set; }

        // Check to see if Queue property is set
        internal bool IsSetInvocationRole()
        {
            return this.InvocationRole != null;
        }
    }
}
