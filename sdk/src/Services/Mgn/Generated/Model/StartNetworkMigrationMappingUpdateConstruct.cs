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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A construct update to apply during a mapping update operation.
    /// </summary>
    public partial class StartNetworkMigrationMappingUpdateConstruct
    {
        private string _constructid;
        private string _constructType;
        private OperationUnion _operation;
        private string _segmentid;

        /// <summary>
        /// Gets and sets the property ConstructID. 
        /// <para>
        /// The ID of the construct to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ConstructID
        {
            get { return this._constructid; }
            set { this._constructid = value; }
        }

        // Check to see if ConstructID property is set
        internal bool IsSetConstructID()
        {
            return this._constructid != null;
        }

        /// <summary>
        /// Gets and sets the property ConstructType. 
        /// <para>
        /// The type of the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=24)]
        public string ConstructType
        {
            get { return this._constructType; }
            set { this._constructType = value; }
        }

        // Check to see if ConstructType property is set
        internal bool IsSetConstructType()
        {
            return this._constructType != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation to perform on the construct.
        /// </para>
        /// </summary>
        public OperationUnion Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentID. 
        /// <para>
        /// The ID of the segment containing the construct.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SegmentID
        {
            get { return this._segmentid; }
            set { this._segmentid = value; }
        }

        // Check to see if SegmentID property is set
        internal bool IsSetSegmentID()
        {
            return this._segmentid != null;
        }

    }
}