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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details on the criteria used to define the filter for investigation results.
    /// </summary>
    public partial class FilterCriteria
    {
        private DateFilter _createdTime;
        private StringFilter _entityArn;
        private StringFilter _severity;
        private StringFilter _state;
        private StringFilter _status;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Filter the investigation results based on when the investigation was created.
        /// </para>
        /// </summary>
        public DateFilter CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// Filter the investigation results based on the Amazon Resource Name (ARN) of the entity.
        /// </para>
        /// </summary>
        public StringFilter EntityArn
        {
            get { return this._entityArn; }
            set { this._entityArn = value; }
        }

        // Check to see if EntityArn property is set
        internal bool IsSetEntityArn()
        {
            return this._entityArn != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// Filter the investigation results based on the severity.
        /// </para>
        /// </summary>
        public StringFilter Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filter the investigation results based on the state.
        /// </para>
        /// </summary>
        public StringFilter State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter the investigation results based on the status.
        /// </para>
        /// </summary>
        public StringFilter Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}