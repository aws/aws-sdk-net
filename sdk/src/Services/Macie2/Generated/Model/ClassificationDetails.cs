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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about a sensitive data finding and the details of the finding.
    /// </summary>
    public partial class ClassificationDetails
    {
        private string _detailedResultsLocation;
        private string _jobArn;
        private string _jobId;
        private OriginType _originType;
        private ClassificationResult _result;

        /// <summary>
        /// Gets and sets the property DetailedResultsLocation. 
        /// <para>
        /// The path to the folder or file in Amazon S3 that contains the corresponding sensitive
        /// data discovery result for the finding. If a finding applies to a large archive or
        /// compressed file, this value is the path to a folder. Otherwise, this value is the
        /// path to a file.
        /// </para>
        /// </summary>
        public string DetailedResultsLocation
        {
            get { return this._detailedResultsLocation; }
            set { this._detailedResultsLocation = value; }
        }

        // Check to see if DetailedResultsLocation property is set
        internal bool IsSetDetailedResultsLocation()
        {
            return this._detailedResultsLocation != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the classification job that produced the finding.
        /// This value is null if the origin of the finding (originType) is AUTOMATED_SENSITIVE_DATA_DISCOVERY.
        /// </para>
        /// </summary>
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier for the classification job that produced the finding. This value
        /// is null if the origin of the finding (originType) is AUTOMATED_SENSITIVE_DATA_DISCOVERY.
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property OriginType. 
        /// <para>
        /// Specifies how Amazon Macie found the sensitive data that produced the finding. Possible
        /// values are: SENSITIVE_DATA_DISCOVERY_JOB, for a classification job; and, AUTOMATED_SENSITIVE_DATA_DISCOVERY,
        /// for automated sensitive data discovery.
        /// </para>
        /// </summary>
        public OriginType OriginType
        {
            get { return this._originType; }
            set { this._originType = value; }
        }

        // Check to see if OriginType property is set
        internal bool IsSetOriginType()
        {
            return this._originType != null;
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The status and other details of the finding.
        /// </para>
        /// </summary>
        public ClassificationResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

    }
}