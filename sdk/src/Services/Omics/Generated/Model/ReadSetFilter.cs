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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// A filter for read sets.
    /// </summary>
    public partial class ReadSetFilter
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private string _generatedFrom;
        private string _name;
        private string _referenceArn;
        private string _sampleId;
        private ReadSetStatus _status;
        private string _subjectId;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The filter's start date.
        /// </para>
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this._createdAfter.GetValueOrDefault(); }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// The filter's end date.
        /// </para>
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this._createdBefore.GetValueOrDefault(); }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GeneratedFrom. 
        /// <para>
        ///  Where the source originated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string GeneratedFrom
        {
            get { return this._generatedFrom; }
            set { this._generatedFrom = value; }
        }

        // Check to see if GeneratedFrom property is set
        internal bool IsSetGeneratedFrom()
        {
            return this._generatedFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceArn. 
        /// <para>
        /// A genome reference ARN to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ReferenceArn
        {
            get { return this._referenceArn; }
            set { this._referenceArn = value; }
        }

        // Check to see if ReferenceArn property is set
        internal bool IsSetReferenceArn()
        {
            return this._referenceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SampleId. 
        /// <para>
        ///  The read set source's sample ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string SampleId
        {
            get { return this._sampleId; }
            set { this._sampleId = value; }
        }

        // Check to see if SampleId property is set
        internal bool IsSetSampleId()
        {
            return this._sampleId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status to filter on.
        /// </para>
        /// </summary>
        public ReadSetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        ///  The read set source's subject ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string SubjectId
        {
            get { return this._subjectId; }
            set { this._subjectId = value; }
        }

        // Check to see if SubjectId property is set
        internal bool IsSetSubjectId()
        {
            return this._subjectId != null;
        }

    }
}