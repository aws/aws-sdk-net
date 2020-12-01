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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Honeycode
{

    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNTING for Format
        /// </summary>
        public static readonly Format ACCOUNTING = new Format("ACCOUNTING");
        /// <summary>
        /// Constant AUTO for Format
        /// </summary>
        public static readonly Format AUTO = new Format("AUTO");
        /// <summary>
        /// Constant CONTACT for Format
        /// </summary>
        public static readonly Format CONTACT = new Format("CONTACT");
        /// <summary>
        /// Constant CURRENCY for Format
        /// </summary>
        public static readonly Format CURRENCY = new Format("CURRENCY");
        /// <summary>
        /// Constant DATE for Format
        /// </summary>
        public static readonly Format DATE = new Format("DATE");
        /// <summary>
        /// Constant DATE_TIME for Format
        /// </summary>
        public static readonly Format DATE_TIME = new Format("DATE_TIME");
        /// <summary>
        /// Constant NUMBER for Format
        /// </summary>
        public static readonly Format NUMBER = new Format("NUMBER");
        /// <summary>
        /// Constant PERCENTAGE for Format
        /// </summary>
        public static readonly Format PERCENTAGE = new Format("PERCENTAGE");
        /// <summary>
        /// Constant ROWLINK for Format
        /// </summary>
        public static readonly Format ROWLINK = new Format("ROWLINK");
        /// <summary>
        /// Constant TEXT for Format
        /// </summary>
        public static readonly Format TEXT = new Format("TEXT");
        /// <summary>
        /// Constant TIME for Format
        /// </summary>
        public static readonly Format TIME = new Format("TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportDataCharacterEncoding.
    /// </summary>
    public class ImportDataCharacterEncoding : ConstantClass
    {

        /// <summary>
        /// Constant ISO88591 for ImportDataCharacterEncoding
        /// </summary>
        public static readonly ImportDataCharacterEncoding ISO88591 = new ImportDataCharacterEncoding("ISO-8859-1");
        /// <summary>
        /// Constant USASCII for ImportDataCharacterEncoding
        /// </summary>
        public static readonly ImportDataCharacterEncoding USASCII = new ImportDataCharacterEncoding("US-ASCII");
        /// <summary>
        /// Constant UTF16 for ImportDataCharacterEncoding
        /// </summary>
        public static readonly ImportDataCharacterEncoding UTF16 = new ImportDataCharacterEncoding("UTF-16");
        /// <summary>
        /// Constant UTF16BE for ImportDataCharacterEncoding
        /// </summary>
        public static readonly ImportDataCharacterEncoding UTF16BE = new ImportDataCharacterEncoding("UTF-16BE");
        /// <summary>
        /// Constant UTF16LE for ImportDataCharacterEncoding
        /// </summary>
        public static readonly ImportDataCharacterEncoding UTF16LE = new ImportDataCharacterEncoding("UTF-16LE");
        /// <summary>
        /// Constant UTF8 for ImportDataCharacterEncoding
        /// </summary>
        public static readonly ImportDataCharacterEncoding UTF8 = new ImportDataCharacterEncoding("UTF-8");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportDataCharacterEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportDataCharacterEncoding FindValue(string value)
        {
            return FindValue<ImportDataCharacterEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportDataCharacterEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportSourceDataFormat.
    /// </summary>
    public class ImportSourceDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant DELIMITED_TEXT for ImportSourceDataFormat
        /// </summary>
        public static readonly ImportSourceDataFormat DELIMITED_TEXT = new ImportSourceDataFormat("DELIMITED_TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportSourceDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportSourceDataFormat FindValue(string value)
        {
            return FindValue<ImportSourceDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportSourceDataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableDataImportJobStatus.
    /// </summary>
    public class TableDataImportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for TableDataImportJobStatus
        /// </summary>
        public static readonly TableDataImportJobStatus COMPLETED = new TableDataImportJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for TableDataImportJobStatus
        /// </summary>
        public static readonly TableDataImportJobStatus FAILED = new TableDataImportJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for TableDataImportJobStatus
        /// </summary>
        public static readonly TableDataImportJobStatus IN_PROGRESS = new TableDataImportJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for TableDataImportJobStatus
        /// </summary>
        public static readonly TableDataImportJobStatus SUBMITTED = new TableDataImportJobStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableDataImportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableDataImportJobStatus FindValue(string value)
        {
            return FindValue<TableDataImportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableDataImportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpsertAction.
    /// </summary>
    public class UpsertAction : ConstantClass
    {

        /// <summary>
        /// Constant APPENDED for UpsertAction
        /// </summary>
        public static readonly UpsertAction APPENDED = new UpsertAction("APPENDED");
        /// <summary>
        /// Constant UPDATED for UpsertAction
        /// </summary>
        public static readonly UpsertAction UPDATED = new UpsertAction("UPDATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpsertAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpsertAction FindValue(string value)
        {
            return FindValue<UpsertAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpsertAction(string value)
        {
            return FindValue(value);
        }
    }

}