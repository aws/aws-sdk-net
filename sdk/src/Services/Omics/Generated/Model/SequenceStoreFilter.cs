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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Omics.Model
{
    /// <summary>
    /// A filter for a sequence store.
    /// </summary>
    public partial class SequenceStoreFilter
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private string _name;
        private SequenceStoreStatus _status;
        private DateTime? _updatedAfter;
        private DateTime? _updatedBefore;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The filter's start date.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter
        {
            get { return this._createdAfter; }
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
        public DateTime? CreatedBefore
        {
            get { return this._createdBefore; }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter results based on status.
        /// </para>
        /// </summary>
        public SequenceStoreStatus Status
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
        /// Gets and sets the property UpdatedAfter. 
        /// <para>
        /// Filter results based on stores updated after the specified time.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAfter
        {
            get { return this._updatedAfter; }
            set { this._updatedAfter = value; }
        }

        // Check to see if UpdatedAfter property is set
        internal bool IsSetUpdatedAfter()
        {
            return this._updatedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBefore. 
        /// <para>
        /// Filter results based on stores updated before the specified time.
        /// </para>
        /// </summary>
        public DateTime? UpdatedBefore
        {
            get { return this._updatedBefore; }
            set { this._updatedBefore = value; }
        }

        // Check to see if UpdatedBefore property is set
        internal bool IsSetUpdatedBefore()
        {
            return this._updatedBefore.HasValue; 
        }

    }
}