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
    /// <para> Output structure for the UpateJob operation. </para>
    /// </summary>
    public class UpdateJobResult  
    {
        
        private bool? success;
        private string warningMessage;

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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateJobResult WithSuccess(bool success)
        {
            this.success = success;
            return this;
        }
            

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this.success.HasValue;       
        }

        /// <summary>
        /// An optional message notifying you of non-fatal issues with the job, such as use of an incompatible Amazon S3 bucket name.
        ///  
        /// </summary>
        public string WarningMessage
        {
            get { return this.warningMessage; }
            set { this.warningMessage = value; }
        }

        /// <summary>
        /// Sets the WarningMessage property
        /// </summary>
        /// <param name="warningMessage">The value to set for the WarningMessage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateJobResult WithWarningMessage(string warningMessage)
        {
            this.warningMessage = warningMessage;
            return this;
        }
            

        // Check to see if WarningMessage property is set
        internal bool IsSetWarningMessage()
        {
            return this.warningMessage != null;       
        }
    }
}
