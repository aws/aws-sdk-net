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
    /// Container for restore job parameters.
    /// </summary>
    public partial class RestoreRequest
    {
        private int? _days;
        private string _description;
        private GlacierJobTier _glacierJobParameters;
        private OutputLocation _outputLocation;
        private RestoreRequestType _restoreRequestType;
        private GlacierJobTier _retrievalTier;
        private SelectParameters _selectParameters;

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        /// Lifetime of the active copy in days. Do not use with restores that specify <c>OutputLocation</c>.
        /// </para>
        ///  
        /// <para>
        /// The Days element is required for regular restores, and must not be provided for select
        /// requests.
        /// </para>
        /// </summary>
        public int? Days
        {
            get { return this._days; }
            set { this._days = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetDays()
        {
            return this._days.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for the job.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GlacierJobParameters. 
        /// <para>
        /// S3 Glacier related parameters pertaining to this job. Do not use with restores that
        /// specify <c>OutputLocation</c>.
        /// </para>
        /// </summary>
        public GlacierJobTier GlacierJobParameters
        {
            get { return this._glacierJobParameters; }
            set { this._glacierJobParameters = value; }
        }

        // Check to see if GlacierJobParameters property is set
        internal bool IsSetGlacierJobParameters()
        {
            return this._glacierJobParameters != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// Describes the location where the restore job's output is stored.
        /// </para>
        /// </summary>
        public OutputLocation OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreRequestType. <important> 
        /// <para>
        /// Amazon S3 Select is no longer available to new customers. Existing customers of Amazon
        /// S3 Select can continue to use the feature as usual. <a href="http://aws.amazon.com/blogs/storage/how-to-optimize-querying-your-data-in-amazon-s3/">Learn
        /// more</a> 
        /// </para>
        ///  </important> 
        /// <para>
        /// Type of restore request.
        /// </para>
        /// </summary>
        public RestoreRequestType RestoreRequestType
        {
            get { return this._restoreRequestType; }
            set { this._restoreRequestType = value; }
        }

        // Check to see if RestoreRequestType property is set
        internal bool IsSetRestoreRequestType()
        {
            return this._restoreRequestType != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalTier. 
        /// <para>
        /// Retrieval tier at which the restore will be processed.
        /// </para>
        /// </summary>
        public GlacierJobTier RetrievalTier
        {
            get { return this._retrievalTier; }
            set { this._retrievalTier = value; }
        }

        // Check to see if RetrievalTier property is set
        internal bool IsSetRetrievalTier()
        {
            return this._retrievalTier != null;
        }

        /// <summary>
        /// Gets and sets the property SelectParameters. <important> 
        /// <para>
        /// Amazon S3 Select is no longer available to new customers. Existing customers of Amazon
        /// S3 Select can continue to use the feature as usual. <a href="http://aws.amazon.com/blogs/storage/how-to-optimize-querying-your-data-in-amazon-s3/">Learn
        /// more</a> 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes the parameters for Select job types.
        /// </para>
        /// </summary>
        public SelectParameters SelectParameters
        {
            get { return this._selectParameters; }
            set { this._selectParameters = value; }
        }

        // Check to see if SelectParameters property is set
        internal bool IsSetSelectParameters()
        {
            return this._selectParameters != null;
        }

    }
}