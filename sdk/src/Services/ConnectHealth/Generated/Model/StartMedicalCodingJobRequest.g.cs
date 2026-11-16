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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Container for the parameters to the StartMedicalCodingJob operation. Starts an asynchronous
    /// job that generates medical codes (ICD-10 and CPT) for clinical text. Call GetMedicalCodingJob
    /// to check the status of the job. When the job succeeds, Amazon Connect Health writes
    /// the results to the output Amazon S3 location. <para> To tailor the codes to your organization,
    /// specify an ACTIVE medical coding dataset in the Domain. If you don't specify a dataset,
    /// the job uses the general medical coding knowledge base. </para> <para> Medical coding
    /// jobs are in preview release and are subject to change. </para>
    /// </summary>
    public partial class StartMedicalCodingJobRequest : AmazonConnectHealthRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier of an ACTIVE medical coding dataset in the Domain to code against.
        /// If you don't specify a dataset, the job uses the general medical coding knowledge
        /// base.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the parent Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 25)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EncounterContext. 
        /// <para>
        /// Encounter context for the job. Providing this information can improve the accuracy
        /// of the medical codes.
        /// </para>
        /// </summary>
        public MedicalCodesEncounterContext EncounterContext { get; set; }

        /// <summary>
        /// Checks to see if the EncounterContext property is set.
        /// </summary>
        internal bool IsSetEncounterContext() => this.EncounterContext != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The output configuration for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MedicalCodingOutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property PatientContext. 
        /// <para>
        /// Patient context for the job. Providing this information can improve the accuracy of
        /// the medical codes.
        /// </para>
        /// </summary>
        public MedicalCodesPatientContext PatientContext { get; set; }

        /// <summary>
        /// Checks to see if the PatientContext property is set.
        /// </summary>
        internal bool IsSetPatientContext() => this.PatientContext != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The clinical text to generate medical codes for, such as a clinical note.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
