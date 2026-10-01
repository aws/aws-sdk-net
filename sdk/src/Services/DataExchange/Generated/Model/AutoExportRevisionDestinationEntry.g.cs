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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// A revision destination is the Amazon S3 bucket folder destination to where the export
    /// will be sent.
    /// </summary>
    public partial class AutoExportRevisionDestinationEntry
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket that is the destination for the event action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property KeyPattern. 
        /// <para>
        /// A string representing the pattern for generated names of the individual assets in
        /// the revision. For more information about key patterns, see <a href="https://docs.aws.amazon.com/data-exchange/latest/userguide/jobs.html#revision-export-keypatterns">Key
        /// patterns when exporting revisions</a>.
        /// </para>
        /// </summary>
        public string KeyPattern { get; set; }

        /// <summary>
        /// Checks to see if the KeyPattern property is set.
        /// </summary>
        internal bool IsSetKeyPattern() => this.KeyPattern != null;
    }
}
