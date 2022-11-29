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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The option that determines the hierarchy of the fields for a visual element.
    /// </summary>
    public partial class ColumnHierarchy
    {
        private DateTimeHierarchy _dateTimeHierarchy;
        private ExplicitHierarchy _explicitHierarchy;
        private PredefinedHierarchy _predefinedHierarchy;

        /// <summary>
        /// Gets and sets the property DateTimeHierarchy. 
        /// <para>
        /// The option that determines the hierarchy of any <code>DateTime</code> fields.
        /// </para>
        /// </summary>
        public DateTimeHierarchy DateTimeHierarchy
        {
            get { return this._dateTimeHierarchy; }
            set { this._dateTimeHierarchy = value; }
        }

        // Check to see if DateTimeHierarchy property is set
        internal bool IsSetDateTimeHierarchy()
        {
            return this._dateTimeHierarchy != null;
        }

        /// <summary>
        /// Gets and sets the property ExplicitHierarchy. 
        /// <para>
        /// The option that determines the hierarchy of the fields that are built within a visual's
        /// field wells. These fields can't be duplicated to other visuals.
        /// </para>
        /// </summary>
        public ExplicitHierarchy ExplicitHierarchy
        {
            get { return this._explicitHierarchy; }
            set { this._explicitHierarchy = value; }
        }

        // Check to see if ExplicitHierarchy property is set
        internal bool IsSetExplicitHierarchy()
        {
            return this._explicitHierarchy != null;
        }

        /// <summary>
        /// Gets and sets the property PredefinedHierarchy. 
        /// <para>
        /// The option that determines the hierarchy of the fields that are defined during data
        /// preparation. These fields are available to use in any analysis that uses the data
        /// source.
        /// </para>
        /// </summary>
        public PredefinedHierarchy PredefinedHierarchy
        {
            get { return this._predefinedHierarchy; }
            set { this._predefinedHierarchy = value; }
        }

        // Check to see if PredefinedHierarchy property is set
        internal bool IsSetPredefinedHierarchy()
        {
            return this._predefinedHierarchy != null;
        }

    }
}