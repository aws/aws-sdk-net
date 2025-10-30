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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The configuration of the compute resources for workers running an analysis with the
    /// Clean Rooms SQL analytics engine.
    /// </summary>
    public partial class WorkerComputeConfiguration
    {
        private int? _number;
        private WorkerComputeConfigurationProperties _properties;
        private WorkerComputeType _type;

        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        ///  The number of workers.
        /// </para>
        ///  
        /// <para>
        /// SQL queries support a minimum value of 2 and a maximum value of 400. 
        /// </para>
        ///  
        /// <para>
        /// PySpark jobs support a minimum value of 4 and a maximum value of 128.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=400)]
        public int Number
        {
            get { return this._number.GetValueOrDefault(); }
            set { this._number = value; }
        }

        // Check to see if Number property is set
        internal bool IsSetNumber()
        {
            return this._number.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The configuration properties for the worker compute environment. These properties
        /// allow you to customize the compute settings for your Clean Rooms workloads.
        /// </para>
        /// </summary>
        public WorkerComputeConfigurationProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The worker compute configuration type.
        /// </para>
        /// </summary>
        public WorkerComputeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}