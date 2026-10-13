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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure that contains information for an analytical engine to validate a view,
    /// prior to persisting the view metadata. Used in the case of direct <c>UpdateTable</c>
    /// or <c>CreateTable</c> API calls.
    /// </summary>
    public partial class ViewValidation
    {
        /// <summary>
        /// Gets and sets the property Dialect. 
        /// <para>
        /// The dialect of the query engine.
        /// </para>
        /// </summary>
        public ViewDialect Dialect { get; set; }

        /// <summary>
        /// Checks to see if the Dialect property is set.
        /// </summary>
        internal bool IsSetDialect() => this.Dialect != null;

        /// <summary>
        /// Gets and sets the property DialectVersion. 
        /// <para>
        /// The version of the dialect of the query engine. For example, 3.0.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DialectVersion { get; set; }

        /// <summary>
        /// Checks to see if the DialectVersion property is set.
        /// </summary>
        internal bool IsSetDialectVersion() => this.DialectVersion != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error associated with the validation.
        /// </para>
        /// </summary>
        public ErrorDetail Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the validation.
        /// </para>
        /// </summary>
        public ResourceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time of the last update.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ViewValidationText. 
        /// <para>
        /// The <c>SELECT</c> query that defines the view, as provided by the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 409600)]
        public string ViewValidationText { get; set; }

        /// <summary>
        /// Checks to see if the ViewValidationText property is set.
        /// </summary>
        internal bool IsSetViewValidationText() => this.ViewValidationText != null;
    }
}
