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
    /// Details of the operation to be performed by the job.
    /// </summary>
    public partial class AutoExportRevisionToS3RequestDetails
    {
        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// Encryption configuration for the auto export job.
        /// </para>
        /// </summary>
        public ExportServerSideEncryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property RevisionDestination. 
        /// <para>
        /// A revision destination is the Amazon S3 bucket folder destination to where the export
        /// will be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoExportRevisionDestinationEntry RevisionDestination { get; set; }

        /// <summary>
        /// Checks to see if the RevisionDestination property is set.
        /// </summary>
        internal bool IsSetRevisionDestination() => this.RevisionDestination != null;
    }
}
