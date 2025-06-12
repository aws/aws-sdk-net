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
    /// A structure containing information about an asynchronous change to a table.
    /// </summary>
    public partial class StatusDetails
    {
        private Table _requestedChange;
        private List<ViewValidation> _viewValidations = AWSConfigs.InitializeCollections ? new List<ViewValidation>() : null;

        /// <summary>
        /// Gets and sets the property RequestedChange. 
        /// <para>
        /// A <c>Table</c> object representing the requested changes.
        /// </para>
        /// </summary>
        public Table RequestedChange
        {
            get { return this._requestedChange; }
            set { this._requestedChange = value; }
        }

        // Check to see if RequestedChange property is set
        internal bool IsSetRequestedChange()
        {
            return this._requestedChange != null;
        }

        /// <summary>
        /// Gets and sets the property ViewValidations. 
        /// <para>
        /// A list of <c>ViewValidation</c> objects that contain information for an analytical
        /// engine to validate a view.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ViewValidation> ViewValidations
        {
            get { return this._viewValidations; }
            set { this._viewValidations = value; }
        }

        // Check to see if ViewValidations property is set
        internal bool IsSetViewValidations()
        {
            return this._viewValidations != null && (this._viewValidations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}