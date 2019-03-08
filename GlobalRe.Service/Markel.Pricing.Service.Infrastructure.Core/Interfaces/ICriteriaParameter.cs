﻿using Markel.Pricing.Service.Infrastructure.Constants;
using System.Data;

namespace Markel.Pricing.Service.Infrastructure.Interfaces
{
    public interface ICriteriaParameter
    {
        #region Properties

        /// <summary>
        /// Gets whether or not the parameter can be added to database parameters, usually
        /// the parameter is not added if this parameter creates several generated parameters 
        /// to add to the database instead of just it's single value.
        /// </summary>
        bool CanAdd { get; }

        /// <summary>
        /// Gets whether or not to add the parameter to the query builder's WHERE clause.
        /// </summary>
        bool CanAddToWhereClause { get; }

        bool IsUpdateOrInsertValue { get; set; }

        /// <summary>
        /// Gets or sets the property name of the object inside the value's collection
        /// to use when the value is a collection of objects.
        /// </summary>
        string CollectionPropertyName { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="CoreVelocity.DataAccess.ComparisonType"/> to use.
        /// </summary>
        ComparisonType ComparisonType { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="CoreVelocity.DataAccess.ConditionType"/> to use.
        /// </summary>
        ConditionType ConditionType { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="System.Data.SqlClient.SqlDbType"/> of the parameter.
        /// </summary>
        SqlDbType? DbType { get; set; }

        /// <summary>
        /// Gets or sets the direction of the parameter in the database.
        /// </summary>
        ParameterDirection Direction { get; set; }
        
        /// <summary>
        /// Gets the formatted parameter name using the internal format 
        /// string from the resource file.
        /// </summary>
        string FormattedName { get; }

        /// <summary>
        /// Gets or sets the <see cref="CoreVelocity.DataAccess.ConditionType"/> to use
        /// between the previous group and this group if they are not the same group.
        /// </summary>
        ConditionType GroupConditionType { get; set; }

        /// <summary>
        /// Gets or sets the group index of the parameter, the group index
        /// tells the process in what order to process the parameter. Parameters
        /// with the same group will be grouped together in the same brackets. Groups
        /// are separated by the next parameters GroupConditionType.
        /// </summary>
        int GroupIndex { get; set; }

        /// <summary>
        /// Gets whether the parameter was autogenerated by the internal processes 
        /// of the <see cref="T:CoreVelocity.DataAccess.DbTable`1"/>
        /// </summary>
        bool IsGenerated { get; }

        /// <summary>
        /// Gets whether the parameter is nullable or not.
        /// </summary>
        bool IsNullable { get; }

        /// <summary>
        /// Gets or sets the name of the parameter in the database.
        /// </summary>
        string ParameterName { get; set; }

        /// <summary>
        /// Gets or sets the property name this parameter is mapped to.
        /// </summary>
        string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the type name the parameter should be mapped to
        /// within the database.
        /// </summary>
        string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the value of the parameter to pass to the database.
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Gets or sets the source column of the mappped
        /// column in the data source, this is used if
        /// no FieldMetaData is availabele for the specified
        /// data for the specified property name.
        /// </summary>
        string SourceColumn { get; set; }

        /// <summary>
        /// Gets or sets the size of the parameter's value.
        /// </summary>
        int? Size { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Returns true or false based on if the CriteriaParamter has a value or not.
        /// </summary>
        /// <returns>true or false based on if the parameter has a value or not.</returns>
        bool HasValue();

        #endregion
    }
}