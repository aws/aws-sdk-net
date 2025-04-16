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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// A container for specifying the configuration for Lambda notifications.
    /// </summary>
    public partial class LambdaFunctionConfiguration
    {
        private List<string> _events = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NotificationConfigurationFilter _filter;
        private string _id;
        private string _lambdaFunctionArn;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The Amazon S3 bucket event for which to invoke the Lambda function. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Supported
        /// Event Types</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public NotificationConfigurationFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function that Amazon S3 invokes when
        /// the specified event type occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LambdaFunctionArn
        {
            get { return this._lambdaFunctionArn; }
            set { this._lambdaFunctionArn = value; }
        }

        // Check to see if LambdaFunctionArn property is set
        internal bool IsSetLambdaFunctionArn()
        {
            return this._lambdaFunctionArn != null;
        }

    }
}