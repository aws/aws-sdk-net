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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure that contains information for an analytical engine to validate a view,
    /// prior to persisting the view metadata. Used in the case of direct <c>UpdateTable</c>
    /// or <c>CreateTable</c> API calls.
    /// </summary>
    public partial class ViewValidation
    {
        private ViewDialect _dialect;
        private string _dialectVersion;
        private ErrorDetail _error;
        private ResourceState _state;
        private DateTime? _updateTime;
        private string _viewValidationText;

        /// <summary>
        /// Gets and sets the property Dialect. 
        /// <para>
        /// The dialect of the query engine.
        /// </para>
        /// </summary>
        public ViewDialect Dialect
        {
            get { return this._dialect; }
            set { this._dialect = value; }
        }

        // Check to see if Dialect property is set
        internal bool IsSetDialect()
        {
            return this._dialect != null;
        }

        /// <summary>
        /// Gets and sets the property DialectVersion. 
        /// <para>
        /// The version of the dialect of the query engine. For example, 3.0.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DialectVersion
        {
            get { return this._dialectVersion; }
            set { this._dialectVersion = value; }
        }

        // Check to see if DialectVersion property is set
        internal bool IsSetDialectVersion()
        {
            return this._dialectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error associated with the validation.
        /// </para>
        /// </summary>
        public ErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the validation.
        /// </para>
        /// </summary>
        public ResourceState State
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time of the last update.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViewValidationText. 
        /// <para>
        /// The <c>SELECT</c> query that defines the view, as provided by the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Max=409600)]
        public string ViewValidationText
        {
            get { return this._viewValidationText; }
            set { this._viewValidationText = value; }
        }

        // Check to see if ViewValidationText property is set
        internal bool IsSetViewValidationText()
        {
            return this._viewValidationText != null;
        }

    }
}