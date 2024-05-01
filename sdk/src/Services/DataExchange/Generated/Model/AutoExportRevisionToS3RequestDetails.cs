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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
        private ExportServerSideEncryption _encryption;
        private AutoExportRevisionDestinationEntry _revisionDestination;

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// Encryption configuration for the auto export job.
        /// </para>
        /// </summary>
        public ExportServerSideEncryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionDestination. 
        /// <para>
        /// A revision destination is the Amazon S3 bucket folder destination to where the export
        /// will be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoExportRevisionDestinationEntry RevisionDestination
        {
            get { return this._revisionDestination; }
            set { this._revisionDestination = value; }
        }

        // Check to see if RevisionDestination property is set
        internal bool IsSetRevisionDestination()
        {
            return this._revisionDestination != null;
        }

    }
}