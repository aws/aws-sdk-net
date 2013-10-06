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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para>This data type is used as a response element to DescribeDBLogFiles.</para>
    /// </summary>
    public class DescribeDBLogFilesDetails
    {
        
        private string logFileName;
        private long? lastWritten;
        private long? size;

        /// <summary>
        /// The name of the log file for the specified DB instance.
        ///  
        /// </summary>
        public string LogFileName
        {
            get { return this.logFileName; }
            set { this.logFileName = value; }
        }

        /// <summary>
        /// Sets the LogFileName property
        /// </summary>
        /// <param name="logFileName">The value to set for the LogFileName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBLogFilesDetails WithLogFileName(string logFileName)
        {
            this.logFileName = logFileName;
            return this;
        }
            

        // Check to see if LogFileName property is set
        internal bool IsSetLogFileName()
        {
            return this.logFileName != null;
        }

        /// <summary>
        /// A POSIX timestamp when the last log entry was written.
        ///  
        /// </summary>
        public long LastWritten
        {
            get { return this.lastWritten ?? default(long); }
            set { this.lastWritten = value; }
        }

        /// <summary>
        /// Sets the LastWritten property
        /// </summary>
        /// <param name="lastWritten">The value to set for the LastWritten property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBLogFilesDetails WithLastWritten(long lastWritten)
        {
            this.lastWritten = lastWritten;
            return this;
        }
            

        // Check to see if LastWritten property is set
        internal bool IsSetLastWritten()
        {
            return this.lastWritten.HasValue;
        }

        /// <summary>
        /// The size, in bytes, of the log file for the specified DB instance.
        ///  
        /// </summary>
        public long Size
        {
            get { return this.size ?? default(long); }
            set { this.size = value; }
        }

        /// <summary>
        /// Sets the Size property
        /// </summary>
        /// <param name="size">The value to set for the Size property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeDBLogFilesDetails WithSize(long size)
        {
            this.size = size;
            return this;
        }
            

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this.size.HasValue;
        }
    }
}
