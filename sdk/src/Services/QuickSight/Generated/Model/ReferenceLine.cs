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
    /// The reference line visual display options.
    /// </summary>
    public partial class ReferenceLine
    {
        private ReferenceLineDataConfiguration _dataConfiguration;
        private ReferenceLineLabelConfiguration _labelConfiguration;
        private WidgetStatus _status;
        private ReferenceLineStyleConfiguration _styleConfiguration;

        /// <summary>
        /// Gets and sets the property DataConfiguration. 
        /// <para>
        /// The data configuration of the reference line.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReferenceLineDataConfiguration DataConfiguration
        {
            get { return this._dataConfiguration; }
            set { this._dataConfiguration = value; }
        }

        // Check to see if DataConfiguration property is set
        internal bool IsSetDataConfiguration()
        {
            return this._dataConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LabelConfiguration. 
        /// <para>
        /// The label configuration of the reference line.
        /// </para>
        /// </summary>
        public ReferenceLineLabelConfiguration LabelConfiguration
        {
            get { return this._labelConfiguration; }
            set { this._labelConfiguration = value; }
        }

        // Check to see if LabelConfiguration property is set
        internal bool IsSetLabelConfiguration()
        {
            return this._labelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the reference line. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLE</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WidgetStatus Status
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
        /// Gets and sets the property StyleConfiguration. 
        /// <para>
        /// The style configuration of the reference line.
        /// </para>
        /// </summary>
        public ReferenceLineStyleConfiguration StyleConfiguration
        {
            get { return this._styleConfiguration; }
            set { this._styleConfiguration = value; }
        }

        // Check to see if StyleConfiguration property is set
        internal bool IsSetStyleConfiguration()
        {
            return this._styleConfiguration != null;
        }

    }
}