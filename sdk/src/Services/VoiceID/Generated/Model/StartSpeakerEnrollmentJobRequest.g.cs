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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Container for the parameters to the StartSpeakerEnrollmentJob operation. Starts a
    /// new batch speaker enrollment job using specified details.
    /// </summary>
    public partial class StartSpeakerEnrollmentJobRequest : AmazonVoiceIDRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The IAM role Amazon Resource Name (ARN) that grants Voice ID permissions to access
        /// customer's buckets to read the input manifest file and write the job output file.
        /// Refer to <a href="https://docs.aws.amazon.com/connect/latest/adminguide/voiceid-batch-enrollment.html">Batch
        /// enrollment using audio data from prior calls</a> for the permissions needed in this
        /// role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the speaker enrollment job and in which
        /// the speakers are enrolled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EnrollmentConfig. 
        /// <para>
        /// The enrollment config that contains details such as the action to take when a speaker
        /// is already enrolled in Voice ID or when a speaker is identified as a fraudster.
        /// </para>
        /// </summary>
        public EnrollmentConfig EnrollmentConfig { get; set; }

        /// <summary>
        /// Checks to see if the EnrollmentConfig property is set.
        /// </summary>
        internal bool IsSetEnrollmentConfig() => this.EnrollmentConfig != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input data config containing the S3 location for the input manifest file that
        /// contains the list of speaker enrollment requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// A name for your speaker enrollment job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The output data config containing the S3 location where Voice ID writes the job output
        /// file; you must also include a KMS key ID to encrypt the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;
    }
}
