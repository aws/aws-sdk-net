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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information about the progress of the schema conversion operation.
    /// </summary>
    public partial class Progress
    {
        /// <summary>
        /// Gets and sets the property ProcessedObject. 
        /// <para>
        /// The name of the database object that the schema conversion operation currently uses.
        /// </para>
        /// </summary>
        public ProcessedObject ProcessedObject { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedObject property is set.
        /// </summary>
        internal bool IsSetProcessedObject() => this.ProcessedObject != null;

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// The percent complete for the current step of the schema conversion operation.
        /// </para>
        /// </summary>
        public double? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressStep. 
        /// <para>
        /// The step of the schema conversion operation. This parameter can store one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> – The operation is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOADING_METADATA</c> – Loads metadata from the source database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COUNTING_OBJECTS</c> – Determines the number of objects involved in the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANALYZING</c> – Analyzes the source database objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONVERTING</c> – Converts the source database objects to a format compatible with
        /// the target database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPLYING</c> – Applies the converted code to the target database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINISHED</c> – The operation completed successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ProgressStep { get; set; }

        /// <summary>
        /// Checks to see if the ProgressStep property is set.
        /// </summary>
        internal bool IsSetProgressStep() => this.ProgressStep != null;

        /// <summary>
        /// Gets and sets the property TotalObjects. 
        /// <para>
        /// The number of objects in this schema conversion operation.
        /// </para>
        /// </summary>
        public long? TotalObjects { get; set; }

        /// <summary>
        /// Checks to see if the TotalObjects property is set.
        /// </summary>
        internal bool IsSetTotalObjects() => this.TotalObjects.HasValue;
    }
}
