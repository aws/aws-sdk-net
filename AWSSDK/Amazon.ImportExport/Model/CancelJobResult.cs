/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// <para> Output structure for the CancelJob operation. </para>
    /// </summary>
    public class CancelJobResult  
    {
        
        private bool? success;

        /// <summary>
        /// Specifies whether (true) or not (false) AWS Import/Export updated your job.
        ///  
        /// </summary>
        public bool Success
        {
            get { return this.success ?? default(bool); }
            set { this.success = value; }
        }

        /// <summary>
        /// Sets the Success property
        /// </summary>
        /// <param name="success">The value to set for the Success property </param>
        /// <returns>this instance</returns>
        public CancelJobResult WithSuccess(bool success)
        {
            this.success = success;
            return this;
        }
            

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this.success.HasValue;       
        }
    }
}
