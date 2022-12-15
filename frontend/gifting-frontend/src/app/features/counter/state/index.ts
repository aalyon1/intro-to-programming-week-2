import { ActionReducerMap, createFeatureSelector, createSelector } from "@ngrx/store";
import { CountData } from "../models";
import * as fromCount from './reducers/count-reducer';

export const featureName = "counter";

export interface CounterState {
    count: fromCount.CountState
}

export const reducers: ActionReducerMap<CounterState> = {
    count: fromCount.reducer
};

const selectFeature = createFeatureSelector<CounterState>(featureName);

const selectCountBranch = createSelector(selectFeature, f => f.count);

export const selectCountCurrent = createSelector(selectCountBranch, b => b.current);
export const selectCountingBy = createSelector(selectCountBranch, b => b.by);
export const selectCountData = createSelector(selectCountBranch, b => b as CountData);