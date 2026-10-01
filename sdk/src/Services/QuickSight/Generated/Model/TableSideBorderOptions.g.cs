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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The side border options for a table.
    /// </summary>
    public partial class TableSideBorderOptions
    {
        /// <summary>
        /// Gets and sets the property Bottom. 
        /// <para>
        /// The table border options of the bottom border.
        /// </para>
        /// </summary>
        public TableBorderOptions Bottom { get; set; }

        /// <summary>
        /// Checks to see if the Bottom property is set.
        /// </summary>
        internal bool IsSetBottom() => this.Bottom != null;

        /// <summary>
        /// Gets and sets the property InnerHorizontal. 
        /// <para>
        /// The table border options of the inner horizontal border.
        /// </para>
        /// </summary>
        public TableBorderOptions InnerHorizontal { get; set; }

        /// <summary>
        /// Checks to see if the InnerHorizontal property is set.
        /// </summary>
        internal bool IsSetInnerHorizontal() => this.InnerHorizontal != null;

        /// <summary>
        /// Gets and sets the property InnerVertical. 
        /// <para>
        /// The table border options of the inner vertical border.
        /// </para>
        /// </summary>
        public TableBorderOptions InnerVertical { get; set; }

        /// <summary>
        /// Checks to see if the InnerVertical property is set.
        /// </summary>
        internal bool IsSetInnerVertical() => this.InnerVertical != null;

        /// <summary>
        /// Gets and sets the property Left. 
        /// <para>
        /// The table border options of the left border.
        /// </para>
        /// </summary>
        public TableBorderOptions Left { get; set; }

        /// <summary>
        /// Checks to see if the Left property is set.
        /// </summary>
        internal bool IsSetLeft() => this.Left != null;

        /// <summary>
        /// Gets and sets the property Right. 
        /// <para>
        /// The table border options of the right border.
        /// </para>
        /// </summary>
        public TableBorderOptions Right { get; set; }

        /// <summary>
        /// Checks to see if the Right property is set.
        /// </summary>
        internal bool IsSetRight() => this.Right != null;

        /// <summary>
        /// Gets and sets the property Top. 
        /// <para>
        /// The table border options of the top border.
        /// </para>
        /// </summary>
        public TableBorderOptions Top { get; set; }

        /// <summary>
        /// Checks to see if the Top property is set.
        /// </summary>
        internal bool IsSetTop() => this.Top != null;
    }
}
