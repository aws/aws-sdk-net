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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The resource utilization for memory, storage, and vCPU for jobs.
    /// </summary>
    public partial class ResourceUtilization
    {
        private double? _memorygbHour;
        private double? _storagegbHour;
        private double? _vcpuHour;

        /// <summary>
        /// Gets and sets the property MemoryGBHour. 
        /// <para>
        /// The aggregated memory used per hour from the time the job starts executing until the
        /// job is terminated.
        /// </para>
        /// </summary>
        public double? MemoryGBHour
        {
            get { return this._memorygbHour; }
            set { this._memorygbHour = value; }
        }

        // Check to see if MemoryGBHour property is set
        internal bool IsSetMemoryGBHour()
        {
            return this._memorygbHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageGBHour. 
        /// <para>
        /// The aggregated storage used per hour from the time the job starts executing until
        /// the job is terminated.
        /// </para>
        /// </summary>
        public double? StorageGBHour
        {
            get { return this._storagegbHour; }
            set { this._storagegbHour = value; }
        }

        // Check to see if StorageGBHour property is set
        internal bool IsSetStorageGBHour()
        {
            return this._storagegbHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VCPUHour. 
        /// <para>
        /// The aggregated vCPU used per hour from the time the job starts executing until the
        /// job is terminated.
        /// </para>
        /// </summary>
        public double? VCPUHour
        {
            get { return this._vcpuHour; }
            set { this._vcpuHour = value; }
        }

        // Check to see if VCPUHour property is set
        internal bool IsSetVCPUHour()
        {
            return this._vcpuHour.HasValue; 
        }

    }
}