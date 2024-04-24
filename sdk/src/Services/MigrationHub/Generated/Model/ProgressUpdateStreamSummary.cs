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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
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
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Summary of the AWS resource used for access control that is implicitly linked to your
    /// AWS account.
    /// </summary>
    public partial class ProgressUpdateStreamSummary
    {
        private string _progressUpdateStreamName;

        /// <summary>
        /// Gets and sets the property ProgressUpdateStreamName. 
        /// <para>
        /// The name of the ProgressUpdateStream. <i>Do not store personal data in this field.</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ProgressUpdateStreamName
        {
            get { return this._progressUpdateStreamName; }
            set { this._progressUpdateStreamName = value; }
        }

        // Check to see if ProgressUpdateStreamName property is set
        internal bool IsSetProgressUpdateStreamName()
        {
            return this._progressUpdateStreamName != null;
        }

    }
}