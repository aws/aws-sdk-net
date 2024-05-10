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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// The required attributes for a generation data group data set. A generation data set
    /// is one of a collection of successive, historically related, catalogued data sets that
    /// together are known as a generation data group (GDG). Use this structure when you want
    /// to import a GDG. For more information on GDG, see <a href="https://www.ibm.com/docs/en/zos/2.3.0?topic=guide-generation-data-sets">Generation
    /// data sets</a>.
    /// </summary>
    public partial class GdgAttributes
    {
        private int? _limit;
        private string _rollDisposition;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of generation data sets, up to 255, in a GDG.
        /// </para>
        /// </summary>
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RollDisposition. 
        /// <para>
        /// The disposition of the data set in the catalog.
        /// </para>
        /// </summary>
        public string RollDisposition
        {
            get { return this._rollDisposition; }
            set { this._rollDisposition = value; }
        }

        // Check to see if RollDisposition property is set
        internal bool IsSetRollDisposition()
        {
            return this._rollDisposition != null;
        }

    }
}